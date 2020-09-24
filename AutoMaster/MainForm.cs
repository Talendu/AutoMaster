using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.Collections;
using EnumsNET;
using System.Threading;
using System.Configuration;
using System.Collections.Concurrent;

namespace AutoMaster
{
    public partial class MainForm : Form
    {
        private bool isOpen = false;
        private int TransmissionCount = 0;
        private int ReceiveCount = 0;
        private bool connecting = false;

        ArrayList rxBuffer = new ArrayList();
        ConcurrentQueue<MyMessage> msgList = new ConcurrentQueue<MyMessage>();
        ConcurrentQueue<ParamList.ParamItem> paramQuaua = new ConcurrentQueue<ParamList.ParamItem>();
        ConfigInfo.ConfigInNvm configInNvm;

        List<ParamList.ParamItem> paramList;
        Thread RegularSendThread = null;
        Thread UpdateUiThread = null;
        Thread myReaderThread = null;
        AutoResetEvent myResetEvent;
        Semaphore sem;
        Semaphore sem_append;

        StringBuilder displayBuffer = new StringBuilder();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                configInNvm = ConfigInfo.GetNvmConfig();
                checkBoxShowInHex.Checked = configInNvm.showInHex;
                checkBoxAutoNewLine.Checked = configInNvm.autoNewLine;
                checkBoxShowInHex.Checked = configInNvm.showSend;
                checkBoxShowInHex.Checked = configInNvm.sendInHex;
                checkBoxShowInHex.Checked = configInNvm.sendNewLine;
                serialPort.BaudRate = configInNvm.baud;
                serialPort.DataBits = configInNvm.dataBits;
                serialPort.StopBits = configInNvm.stopBits;
                serialPort.Parity = configInNvm.parity;
            }
            catch(Exception)
            {
                MessageBox.Show("文件信息缺失，读取信息失败，请重装软件", "错误");
            }
            StatusStrip_Init();
            tbxCycle.Text = configInNvm.period.ToString();

            serialPort.ReadTimeout = 1000000 / serialPort.BaudRate;

            paramList = ParamList.ParamList_Init();
            int i;
            for (i = 0; i < paramList.Count; i++)
            {
                DataGridView grid;
                ParamList.ParamItem item = paramList[i];
                if (item.id < 256)
                {
                    grid = dataGridView_param;
                }
                else if (item.id < 258)
                {
                    grid = dataGridView_do;
                }
                else if (item.id < 260)
                {
                    grid = dataGridView_di;
                }
                else
                {
                    break;
                }
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.id.ToString();
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.name);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.value);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.unit);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.description);
                listView_State.Items.Add(listItem);
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = item.id.ToString();
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = item.name;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = item.value;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = item.unit;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = item.description;
                row.Cells.Add(cell);
                grid.Rows.Add(row);
                if (item.bitMap.Count > 0)
                {
                    foreach (ParamList.BitMap bit in item.bitMap)
                    {
                        row = new DataGridViewRow();
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = item.id.ToString();
                        cell.Style.ForeColor = Color.White;
                        cell.Style.Alignment = DataGridViewContentAlignment.BottomRight;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        if (bit.bitstart == bit.bitend)
                        {
                            cell.Value = "bit"+ bit.bitstart.ToString().PadLeft(2, '0') + ": " + bit.name;
                        }
                        else
                        {
                            cell.Value = "bit[" + bit.bitstart.ToString().PadLeft(2, '0')
                                + "," + bit.bitend.ToString().PadLeft(2, '0') + "]: " + bit.name;
                        }
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = bit.value;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = bit.unit;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = bit.description;
                        row.Cells.Add(cell);
                        grid.Rows.Add(row);
                    }
                }
            }
            dataGridView_param.AllowUserToAddRows = false;
            dataGridView_param.AllowUserToDeleteRows = false;
            listView_State.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_State.Columns[0].TextAlign = HorizontalAlignment.Center;
            listView_State.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView_State.Columns[1].TextAlign = HorizontalAlignment.Center;
            //listView_State.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_State.Columns[2].TextAlign = HorizontalAlignment.Center;
            listView_State.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_State.Columns[3].TextAlign = HorizontalAlignment.Center;
            listView_State.Columns[4].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView_State.Columns[4].TextAlign = HorizontalAlignment.Center;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceive);


            dataGridView_di.AllowUserToAddRows = false;
            dataGridView_di.AllowUserToDeleteRows = false;


            dataGridView_do.AllowUserToAddRows = false;
            dataGridView_do.AllowUserToDeleteRows = false;

            UpdateUiThread = new Thread(new ThreadStart(updateUiMethod));
            UpdateUiThread.Start();
            tabControl1.TabPages.RemoveAt(1);
            myReaderThread = new Thread(new ThreadStart(MyReadThreadProc));
            myResetEvent = new AutoResetEvent(false);
            sem = new Semaphore(1, 1);
            sem_append = new Semaphore(1, 1);
            myReaderThread.Start();
        }

        void updateUiMethod()
        {
            while (true)
            {
                try
                {

                    /*
                    for (int i = paramQuaua.Count; i > 0; i--)
                    {
                        ParamList.ParamItem item;
                        paramQuaua.TryDequeue(out item);
                        listView_State_Update(item);
                    }
                    */
                    foreach (ParamList.ParamItem item in paramList)
                    {
                        listView_State_Update(item);
                    }

                    this.Invoke((EventHandler)(delegate
                    {
                        tbxReceiveCount.Text = ReceiveCount.ToString();
                        tbxSendCount.Text = TransmissionCount.ToString();
                    }));
                    MyMessage msg;
                    bool update = false;
                    //if (msgList.Count > 0)
                    {
                        update = true;
                    }
                    for (int i = msgList.Count; i > 0; i--)
                    {
                        if (msgList.TryDequeue(out msg))
                            ShowMessage(msg);

                    }
                    if (update)
                    {
                        this.Invoke((EventHandler)(delegate
                        {
                            //tbxData.SelectionStart = tbxData.TextLength;
                            //tbxData.ScrollToCaret();
                            sem_append.WaitOne();
                            tbxData.AppendText(displayBuffer.ToString());
                            displayBuffer.Clear();
                            sem_append.Release();
                            GC.Collect();

                        }));
                    }
                    Thread.Sleep(200);
                }
                catch (Exception) { }
            }
        }
        private byte[] rxBuff;
        private void MyReadThreadProc()
        {
            int i;
            while (true)
            {
                myResetEvent.WaitOne();
                sem.WaitOne();
                rxBuffer.AddRange(rxBuff);
                ReceiveCount += rxBuff.Length;
                sem.Release();
                if (configInNvm.showInHex)
                {
                    ShowBytes(rxBuff, 2);
                }
                else
                {
                    ShowBytes(rxBuff, 1);
                }

                for (i = ParamList.ParamList_Update(paramList, rxBuffer); i > 0; i++)
                {
                    if (connecting)
                    {
                        serialHexTransmission("5a 00 00 80 00 0a");
                    }
                }
            }
        }
        private void serialDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            sem.WaitOne();
            rxBuff = new byte[serialPort.BytesToRead];
            serialPort.Read(rxBuff, 0, rxBuff.Length);
            
            sem.Release();
            myResetEvent.Set();

        }
        private void listView_State_Update(List<ParamList.ParamItem> list)
        {
            foreach (ParamList.ParamItem item in list)
            {
                int listIndex = ParamList.FindById(paramList, item.id);
                if (listIndex < 0)
                {
                    continue;
                }
                this.Invoke((EventHandler)(delegate
                {
                    try
                    {
                        listView_State.Items[listIndex].SubItems[2].Text = item.value;
                        dataGridView_param.Rows[listIndex].Cells[2].Value = item.value;
                    }
                    catch (Exception)
                    {

                    }
                }));
            }
        }

        private DataGridView findGridViewById(int id)
        {
            if (id < 256)
            {
                return dataGridView_param;
            }
            else if (id < 258)
            {
                return dataGridView_do;

            }
            else if (id < 260)
            {
                return dataGridView_di;
            }
            else
            {
                return dataGridView_di;
                //return null;
            }
        }

        private void listView_State_Update(ParamList.ParamItem item)
        {
            int listIndex = ParamList.FindById(paramList, item.id);
            int i;
            string parentValue = null;
            DataGridView grid = findGridViewById(item.id);
            if (listIndex < 0)
            {
                return;
            }
            if (grid == null)
            { 
                return;
            }
            this.Invoke((EventHandler)(delegate
            {
                try
                {
                    parentValue = paramList[listIndex].value;
                    if (parentValue == null || parentValue.Length == 0)
                    {
                        return;
                    }
                    //listView_State.Items[listIndex].SubItems[2].Text = item.value;
                    for (i = 0; i < grid.Rows.Count; i++)
                    {
                        if (grid.Rows[i].Cells[0].Value.Equals(item.id.ToString()) &&
                            !grid.Rows[i].Cells[2].IsInEditMode)
                        {
                            string name = grid.Rows[i].Cells[1].Value.ToString().Split(':')[0];

                            if (name.Substring(0, 3).Equals("bit"))
                            {
                                int shift;
                                int width = 0;
                                int oldValue = Convert.ToInt32(parentValue);
                                if (name.Substring(3, 1).Equals("["))
                                {
                                    shift = Convert.ToInt32(name.Substring(3, 2));
                                    width = Convert.ToInt32(name.Substring(6, 2)) - shift;
                                }
                                else
                                {
                                    shift = Convert.ToInt32(name.Substring(3, 2));
                                    width = 1;
                                }
                                grid.Rows[i].Cells[2].Value = (Convert.ToUInt32(parentValue) >> shift) & ((1 << width) - 1);
                            }
                            else
                            {
                                grid.Rows[i].Cells[2].Value = parentValue;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }));
        }

        private void serialTextTransmission(string data)
        {
            byte[] buff;
            if (checkBoxSendNewLine.CheckState == CheckState.Checked)
            {
                data += "\r\n";
            }
            buff = Encoding.Default.GetBytes(data);
            if (checkBoxShowSend.CheckState == CheckState.Checked)
            {
                MyMessage msg = new MyMessage(1);
                msg.SetObj(Encoding.Default.GetString(buff));
                ShowMessage(msg);
            }
            TransmissionCount += buff.Length;
            serialPort.Write(buff, 0, buff.Length);
        }

        private void serialHexTransmission(string data)
        {
            Byte[] Buff = new Byte[(data.Length + 1) / 2 + 2];
            int Len = 0;
            Len = hex2num(data, Buff);

            if (checkBoxSendNewLine.CheckState == CheckState.Checked)
            {
                Buff[Len++] = (byte)'\r';
                Buff[Len++] = (byte)'\n';
            }

            TransmissionCount += Len;
            serialPort.Write(Buff, 0, Len);
            if (checkBoxShowSend.CheckState == CheckState.Checked)
            {
                MyMessage msg = new MyMessage(1);
                msg.SetObj(data);
                ShowMessage(msg);
            }
        }

        private void serialDataTransmission(string data)
        {
            if (isOpen == false)
            {
                return;
            }
            if (data == null || data.CompareTo("") == 0)
            {
                return;
            }

            if (checkBoxSendHex.CheckState == CheckState.Unchecked)
            {
                serialTextTransmission(data);
            }
            else
            {
                serialHexTransmission(data);
            }
            GC.Collect();
        }

        private void ShowBytes(byte[] buff, int type)
        {
            string receive = null;
            switch (type)
            {
                case 1:
                    receive = Encoding.Default.GetString(buff);
                    break;
                case 2:
                    for (int i = 0; i < buff.Length; i++)
                    {
                        receive += buff[i].ToString("X2") + " ";
                    }
                    break;
                default:
                    return;
            }
            MyMessage message = new MyMessage(2);
            message.SetObj(receive);

            ShowMessage(message);
        }
        
        private void ShowMessage(object msg)
        {
            MyMessage message = (MyMessage)msg;
            if (message == null || message.GetObj() == null)
            {
                return;
            }
            sem_append.WaitOne();
            switch (message.GetWhat())
            {
            case 1:
                {
                    if (checkBoxShowSend.CheckState == CheckState.Checked)
                    {
                        //tbxData.SelectionStart = tbxData.TextLength;
                        //tbxData.SelectionColor = Color.OrangeRed;
                        if (configInNvm.timeStamp)
                        {
                            displayBuffer.Append(DateTime.Now.ToString("hh:mm:ss.fff") + " ");
                        }
                        displayBuffer.Append("发: ");
                        displayBuffer.Append((string)message.GetObj());
                        if (checkBoxAutoNewLine.CheckState == CheckState.Checked)
                        {
                            displayBuffer.Append("\r\n");
                        }
                        //tbxData.ScrollToCaret();
                    }
                    break;
                }
            case 2:
                {
                    //tbxData.SelectionStart = tbxData.TextLength;
                    //tbxData.SelectionColor = Color.Blue;
                    if (configInNvm.timeStamp)
                    {
                        displayBuffer.Append(DateTime.Now.ToString("hh:mm:ss.fff") + " ");
                    }
                    displayBuffer.Append("收: ");
                    displayBuffer.Append((string)message.GetObj());
                    if (checkBoxAutoNewLine.CheckState == CheckState.Checked)
                    {
                        displayBuffer.Append("\r\n");
                    }
                    //tbxData.ScrollToCaret();
                    break;
                }
            case 3:
                {
                    //tbxData.SelectionStart = tbxData.TextLength;
                    //tbxData.SelectionColor = Color.Red;
                    if (configInNvm.timeStamp)
                        displayBuffer.Append(DateTime.Now.TimeOfDay.ToString("hh:mm:ss.fff") + " ");
                    displayBuffer.Append("错误: ");
                    displayBuffer.Append((string)message.GetObj());
                    displayBuffer.Append("\r\n");
                    //tbxData.ScrollToCaret();
                    break;
                }
            case 4:
                {
                    //tbxData.SelectionStart = tbxData.TextLength;
                    //tbxData.SelectionColor = Color.Black;
                    if (configInNvm.timeStamp)
                        displayBuffer.Append(DateTime.Now.TimeOfDay.ToString("hh:mm:ss.fff") + " ");
                    displayBuffer.Append("警告: ");
                    displayBuffer.Append((string)message.GetObj());
                    break;
                }
            }
            sem_append.Release();
        }

        private void statusStrip_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            ToolStripDropDownButton button = (ToolStripDropDownButton)sender;
            string buttonn_value = button.Text.Substring(5) + "";

            if (e.ClickedItem.Text == null
                || e.ClickedItem.Text.Equals("")
                || buttonn_value.CompareTo(e.ClickedItem.Text.Trim()) == 0)
            {
                return;
            }

            if (button.Equals(statusStrip_Com))
            {
                if (isOpen)
                {
                    try
                    {
                        serialPort.Close();
                        isOpen = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("\r\n错误:改变端口失败!\r\n");
                        return;
                    }
                }
                statusStrip_Com.Text = "串口号: " + e.ClickedItem.Text;
                serialPort.PortName = e.ClickedItem.Text.Trim();
                statusStrip_Enable_Click(null, null);
            }
            else if (button.Equals(statusStrip_Baud))
            {
                try
                {
                    string baudText;
                    if (e.ClickedItem.Text.Trim().Equals("Custom"))
                    {
                        baudText = ((ToolStripMenuItem)e.ClickedItem).DropDownItems[0].Text;
                    }
                    else
                    {
                        baudText = e.ClickedItem.Text;
                    }
                    
                    serialPort.BaudRate = Convert.ToInt32(baudText.Trim());
                    button.Text = "波特率: " + baudText;
                    configInNvm.baud = serialPort.BaudRate;
                }
                catch (Exception)
                {
                    MessageBox.Show("\r\n错误:非法波特率!\r\n");
                }
            }
            else if(button.Equals(statusStrip_DataBits))
            {
                try
                {
                    serialPort.DataBits = Convert.ToInt32(e.ClickedItem.Text.Trim());
                    button.Text = "数据位: " + e.ClickedItem.Text;
                    configInNvm.dataBits = serialPort.DataBits;
                }
                catch (Exception)
                {
                    MessageBox.Show("\r\n错误:非法数据位!\r\n");
                }
            }
            else if (button.Equals(statusStrip_StopBit))
            {
                try
                {
                    foreach(var stopBits in Enums.GetMembers<StopBits>())
                    {
                        if (stopBits.ToString().Equals(e.ClickedItem.Text.Trim()))
                        {
                            serialPort.StopBits = stopBits.Value;
                            configInNvm.stopBits = serialPort.StopBits;
                        }
                    }
                    button.Text = "停止位: " + e.ClickedItem.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("\r\n错误:非法停止位!\r\n");
                }
            }
            else if (button.Equals(statusStrip_Parity))
            {
                try
                {
                    foreach (var parity in Enums.GetMembers<Parity>())
                    {
                        if (parity.ToString().Equals(e.ClickedItem.Text.Trim()))
                        {
                            serialPort.Parity = parity.Value;
                            configInNvm.parity = serialPort.Parity;
                        }
                    }
                    button.Text = "校验位: " + e.ClickedItem.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("\r\n错误:非法校验位!\r\n");
                }
            }
        }

        private void GetSerialPort()   //获取串口列表  
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null && keyCom.ValueCount != 0)
            {
                string[] sSubKeys = keyCom.GetValueNames();

                //sSubKeys = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");

                foreach (string sName in sSubKeys)
                {
                    ToolStripMenuItem stripTextBox = new ToolStripMenuItem();
                    string sValue = (string)keyCom.GetValue(sName);
                    stripTextBox.Text = sValue;
                    statusStrip_Com.DropDownItems.Add(stripTextBox);
                }
            }
            else
            {
                statusStrip_Com.DropDownItems.Add(new ToolStripMenuItem());
            }
        }
        private void StatusStrip_Init()
        {
            ToolStripMenuItem stripTextBox = new ToolStripMenuItem();
            statusStrip_Com.DropDownItems.Add(stripTextBox);

            foreach (string item in ConfigInfo.Bauds)
            {
                stripTextBox = new ToolStripMenuItem();
                stripTextBox.Text = item;
                if (item.Equals("Custom"))
                {
                    ToolStripTextBox textBox = new ToolStripTextBox();
                    textBox.Name = "CustomBaud";
                    textBox.TextChanged += new EventHandler(textChanged);
                    stripTextBox.DropDownItems.Add(textBox);
                }
                statusStrip_Baud.DropDownItems.Add(stripTextBox);
            }
            statusStrip_Baud.Text = "波特率: " + serialPort.BaudRate;

            foreach (int dataBit in ConfigInfo.DataBits)
            {
                stripTextBox = new ToolStripMenuItem();
                stripTextBox.Text = dataBit.ToString();
                statusStrip_DataBits.DropDownItems.Add(stripTextBox);
            }
            statusStrip_DataBits.Text = "数据位: " + serialPort.DataBits;

            foreach (string stopbit in Enum.GetNames(typeof(StopBits)))
            {
                if (stopbit.Equals("None"))
                    continue;
                stripTextBox = new ToolStripMenuItem();
                stripTextBox.Text = stopbit.ToString();
                statusStrip_StopBit.DropDownItems.Add(stripTextBox);
            }
            statusStrip_StopBit.Text = "停止位: " + serialPort.StopBits;

            foreach (string parity in Enum.GetNames(typeof(Parity)))
            {
                stripTextBox = new ToolStripMenuItem();
                stripTextBox.Text = parity.ToString();
                statusStrip_Parity.DropDownItems.Add(stripTextBox);
            }
            statusStrip_Parity.Text = "校验位: " + serialPort.Parity;
        }
        private void textChanged(object sender, EventArgs e)
        {
        }
        private void statusStrip_Com_DropDownOpening(object sender, EventArgs e)
        {
            statusStrip_Com.DropDownItems.Clear();
            GetSerialPort();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            tbxData.Clear();
            TransmissionCount = 0;
            ReceiveCount = 0;
            tbxSendCount.Text = "0";
            tbxReceiveCount.Text = "0";
            GC.Collect();
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            tbxSend.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                statusStrip_Enable_Click(null, null);
            }
            serialDataTransmission(tbxSend.Text);
        }

        public static int hex2num(string Hexs, Byte[] Buff)
        {
            Int32 Len = 0;
            Int32 HexCycle = 0;
            int value = 0;
            foreach (char Hex in Hexs)
            {
                if ('0' <= Hex && Hex <= '9')
                {
                    value <<= 4;
                    value += Hex - '0';
                    HexCycle++;
                }
                else if ('a' <= Hex && Hex <= 'f')
                {
                    value <<= 4;
                    value += Hex - 'a' + 10;
                    HexCycle++;
                }
                else if ('A' <= Hex && Hex <= 'F')
                {
                    value <<= 4;
                    value += Hex - 'A' + 10;
                    HexCycle++;
                }
                else if (Hex == ' ')
                {
                    if (HexCycle == 1)
                    {
                        HexCycle = 0;
                        Buff[Len] = (Byte)value;
                        value = 0;
                        Len++;
                    }
                }
                else
                {
                    break;
                }

                if (HexCycle == 2)
                {
                    HexCycle = 0;
                    Buff[Len] = (Byte)value;
                    value = 0;
                    Len++;
                }
            }
            if (HexCycle == 1)
            {
                HexCycle = 0;
                Buff[Len] = (Byte)value;
                value = 0;
                Len++;
            }
            if (Len == 0)
            {
                Buff.Initialize();
                return 0;
            }
            return Len;
        }

        private void RegularSenMethod()
        {
            while (checkBoxSendRegular != null 
                && checkBoxSendRegular.CheckState == CheckState.Checked)
            {
                this.Invoke((EventHandler)(delegate
                {
                    try
                    {
                        serialDataTransmission(tbxSend.Text);
                        if (isOpen == false || tbxSend.Text.CompareTo("") == 0)
                        {
                            checkBoxSendRegular.Checked = false;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }));
                do
                {
                    try
                    {
                        Thread.Sleep(configInNvm.period);
                    }
                    catch (Exception)
                    {

                    }
                } while (serialPort.BytesToWrite > 0);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            configInNvm.showInHex = checkBoxShowInHex.Checked;
            configInNvm.autoNewLine = checkBoxAutoNewLine.Checked;
            configInNvm.showSend = checkBoxShowSend.Checked;
            configInNvm.sendInHex = checkBoxSendHex.Checked;
            configInNvm.sendNewLine = checkBoxSendNewLine.Checked;
            configInNvm.timeStamp = checkBoxTimeStamp.Checked;
        }

        private void checkBoxSendRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSendRegular.CheckState == CheckState.Checked)
            {
                if (isOpen == false)
                {
                    checkBoxSendRegular.Checked = false;
                    return;
                }
                if (RegularSendThread == null)
                {
                    RegularSendThread = new Thread(new ThreadStart(RegularSenMethod));
                    RegularSendThread.Start();
                }
            }
            if (checkBoxSendRegular.CheckState == CheckState.Unchecked)
            {
                if (RegularSendThread != null)
                {
                    RegularSendThread.Abort();
                    RegularSendThread = null;
                }
            }
        }

        private void Menu_File_Save_Click(object sender, EventArgs e)
        {
            if (tbxData.Text == null
                || tbxData.Text.Equals(""))
            {
                MessageBox.Show("内容为空");
                return;
            }
            saveFileDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd_hh.mm.ss ");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fileName, tbxData.Text);
            }
        }

        private void Menu_File_Open_Click(object sender, EventArgs e)
        {
            if (tbxData.Text != null
                && !tbxData.Text.Equals("")
                && MessageBox.Show("窗口中消息不为空, 打开文件将覆盖窗口中的内容\n是否继续", "注意",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;/*
                System.IO.FileInfo fileInfo = null;
                try
                {
                    fileInfo = new System.IO.FileInfo(fileName);
                    if (fileInfo.Length > 2048000)
                    {
                        MessageBox.Show("无法打开超过2M的文件", "注意",MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                }*/

                string fileData = Encoding.Default.GetString(System.IO.File.ReadAllBytes(fileName));
                //string fileData = System.IO.File.ReadAllText(fileName);
                MyMessage msg = new MyMessage(4);
                btnClearData_Click(null, null);
                msg.SetObj(fileData);
                ShowMessage(msg);
            }
        }

        private void statusStrip_Enable_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                try
                {
                    serialPort.Close();
                    statusStrip_Enable.Image = Properties.Resources.off;
                    statusStrip_Enable.Text = "关闭";
                    statusStrip_Enable.ForeColor = Color.Red;
                    isOpen = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口失败");
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                    statusStrip_Enable.Image = Properties.Resources.on;
                    statusStrip_Enable.Text = "开启";
                    statusStrip_Enable.ForeColor = Color.Green;
                    isOpen = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("打开串口失败");
                }
            }
        }
        private void MainForm_OnClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ConfigInfo.SaveConfigToNvm(configInNvm);
                checkBoxSendRegular.Checked = false;
                // serialPort.Close();
                 RegularSendThread.Abort();
                UpdateUiThread.Abort();
                serialPort.Dispose();
                Thread.Sleep(100);
                serialPort.Close();
                Thread.Sleep(100);
                serialPort.Dispose();
                Thread.Sleep(100);
            }
            catch (Exception)
            { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ConfigInfo.SaveConfigToNvm(configInNvm);
                if (checkBoxSendRegular != null)
                {
                    checkBoxSendRegular.Checked = false;
                }
                // serialPort.Close();
                if (RegularSendThread != null)
                    RegularSendThread.Abort();
                if (UpdateUiThread != null)
                    UpdateUiThread.Abort();
                Thread.Sleep(100);
                serialPort.Close();
                Thread.Sleep(100);
                serialPort.Dispose();
                Thread.Sleep(100);
                myReaderThread.Abort();
            }
            catch (Exception)
            { }
        }

        private void Menu_Setting_Font_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                tbxData.Font = fontDialog.Font;
                tbxSend.Font = fontDialog.Font;
                listView_State.Font = fontDialog.Font;
                dataGridView_di.Font = fontDialog.Font;
                dataGridView_do.Font = fontDialog.Font;
                dataGridView_param.Font = fontDialog.Font;
                //MessageBox.Show(fontDialog.Font.ToString());
            }

        }
        private void Menu_VIew_Page_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < paramList.Count; i++)
            {
                UInt16 value = 32767;
                rxBuffer.AddRange(new byte[] { 0x5a, i, 0, 2, Convert.ToByte(value&0xff),
                    Convert.ToByte(value >> 8), 0, Convert.ToByte('\n') });
                //listView_State_Update(ParamList.ParamList_Update(paramList, rxBuffer));
            }
        }

        private void dataGridView_param_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void btn_startCom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (connecting)
            {
                btn.Text = "开始通信";
                connecting = false;
            }
            else
            {
                if (isOpen == false)
                {
                    statusStrip_Enable_Click(null, null);
                }
                if (isOpen)
                {
                    btn.Text = "停止通信";
                    connecting = true;
                    serialHexTransmission("5a 00 00 20 00 0a");
                }
            }
        }

        private void dataGridView_param_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int listIndex = 0;
            if (isOpen == false)
            {
                statusStrip_Enable_Click(null, null);
            }
            if (isOpen)
            {
                DataGridView view = (DataGridView)sender;
                try
                {
                    int id = Convert.ToInt32(view.Rows[e.RowIndex].Cells[0].Value);
                    listIndex = ParamList.FindById(paramList, id);
                    double value = Convert.ToInt32(view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    if (listIndex < 0)
                    {
                        view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        return;
                    }
                    if (paramList[listIndex].formula != null &&
                        paramList[listIndex].formula.Length > 0 &&
                        paramList[listIndex].formula.Substring(0, 1).Equals("/"))
                    {
                        string formula = paramList[listIndex].formula.Substring(1);
                        value = value * Convert.ToDouble(formula);
                    }
                    int intValue = 65535;
                    if (value < 65536)
                    {
                        intValue = (int)value;
                    }
                    string name = view.Rows[e.RowIndex].Cells[1].Value.ToString().Split(':')[0];
                    if (name.Substring(0,3).Equals("bit"))
                    {
                        int shift;
                        int width = 0;
                        int oldValue = Convert.ToInt32(paramList[listIndex].value);
                        if (name.Substring(3, 1).Equals("["))
                        {
                            shift = Convert.ToInt32(name.Substring(3, 2));
                            width = Convert.ToInt32(name.Substring(6, 2)) - shift;
                        }
                        else
                        {
                            shift = Convert.ToInt32(name.Substring(3, 2));
                            width = 1;
                        }
                        if (intValue >= (1 << width))
                        {
                            view.Rows[e.RowIndex].Cells[2].Value = ((oldValue >> shift) & ((1 << width) - 1)).ToString();
                            return;
                        }
                        else
                        {
                            int mask = (1 << width) - 1;
                            intValue = (oldValue & (~(mask << shift))) + (intValue << shift);
                        }
                    }
                    string strValue = "ff ff";
                    if (intValue < 65536)
                    {
                        byte value0 = (byte)(intValue & 0xff);
                        byte value1 = (byte)(intValue >> 8);
                        strValue = value0.ToString("x").PadLeft(2, '0') + " "
                            + value1.ToString("x").PadLeft(2, '0');
                    }
                    paramList[listIndex].value = intValue.ToString();

                    serialHexTransmission("5a " + (id & 0xff).ToString("x").PadLeft(2, '0') + " "
                        + (id  >> 8).ToString("x").PadLeft(2, '0') + " "
                        + paramList[listIndex].type.ToString("x").PadLeft(2, '0') + " " 
                        + strValue + " 00 0a");
                }
                catch (Exception) { }
            }
            //paramQuaua.Enqueue(paramList[listIndex]);
        }
    }
}
