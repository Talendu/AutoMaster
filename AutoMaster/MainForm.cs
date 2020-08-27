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

namespace AutoMaster
{
    public partial class MainForm : Form
    {
        private bool isOpen = false;
        private int TransmissionCount = 0;
        private int ReceiveCount = 0;
        int RegularCycle = 10;

        Thread RegularSendThread = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StatusStrip_Init();
            tbxCycle.Text = RegularCycle.ToString();

            serialPort.ReadTimeout = 1000000 / serialPort.BaudRate;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceive);

        }

        private void serialDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buff = new byte[serialPort.BytesToRead];
            serialPort.Read(buff, 0, buff.Length);
            ReceiveCount += buff.Length;
            if (checkBoxShowInHex.CheckState == CheckState.Checked)
            {
                ShowBytes(buff, 2);
            }
            else
            {
                ShowBytes(buff, 1);
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
                tbxSendCount.Text = (TransmissionCount).ToString();
                serialPort.Write(buff, 0, buff.Length);
            }
            else
            {
                Byte[] Buff = new Byte[(tbxSend.Text.Length + 1) / 2 + 2];
                int Len = 0;
                Len = hex2num(tbxSend.Text, Buff);

                if (checkBoxSendNewLine.CheckState == CheckState.Checked)
                {
                    Buff[Len++] = (byte)'\r';
                    Buff[Len++] = (byte)'\n';
                }

                TransmissionCount += Len;
                tbxSendCount.Text = (TransmissionCount).ToString();
                serialPort.Write(Buff, 0, Len);
                if (checkBoxShowSend.CheckState == CheckState.Checked)
                {
                    MyMessage msg = new MyMessage(1);
                    msg.SetObj(tbxSend.Text);
                    ShowMessage(msg);
                }
            }
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
            this.Invoke((EventHandler)(delegate
            {
                tbxReceiveCount.Text = ReceiveCount.ToString();
                ShowMessage(message);
            }));
        }

        private void ShowMessage(object msg)
        {
            MyMessage message = (MyMessage)msg;
            if (message == null || message.GetObj() == null)
            {
                return;
            }
            this.Invoke((EventHandler)(delegate
            {

                switch (message.GetWhat())
                {
                    case 1:
                        {
                            if (checkBoxShowSend.CheckState == CheckState.Checked)
                            {
                                tbxData.SelectionStart = tbxData.Text.Length;
                                tbxData.SelectionColor = Color.OrangeRed;
                                tbxData.AppendText((string)message.GetObj());
                                if (checkBoxAutoNewLine.CheckState == CheckState.Checked)
                                {
                                    tbxData.AppendText("\r\n");
                                }
                                tbxData.ScrollToCaret();
                            }
                            break;
                        }
                    case 2:
                        {
                            tbxData.SelectionStart = tbxData.Text.Length;
                            tbxData.SelectionColor = Color.Blue;
                            tbxData.AppendText((string)message.GetObj());
                            if (checkBoxAutoNewLine.CheckState == CheckState.Checked)
                            {
                                tbxData.AppendText("\r\n");
                            }
                            tbxData.ScrollToCaret();
                            break;
                        }
                    case 3:
                        {
                            tbxData.SelectionStart = tbxData.Text.Length;
                            tbxData.SelectionColor = Color.Red;
                            tbxData.AppendText((string)message.GetObj());
                            tbxData.AppendText("\r\n");
                            tbxData.ScrollToCaret();
                            break;
                        }
                }
            }));
        }

        private void Menu_FIle_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void Menu_FIle_Open_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
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
                statusStrip_Com.Text = "串口号: " + e.ClickedItem.Text;

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
                    }
                }
                serialPort.PortName = e.ClickedItem.Text.Trim();
                if (!isOpen)
                {
                    try
                    {
                        serialPort.Open();
                        isOpen = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("\r\n错误:改变端口失败!\r\n");
                    }
                }
            }
            else if (button.Equals(statusStrip_Baud))
            {
                try
                {
                    serialPort.BaudRate = Convert.ToInt32(e.ClickedItem.Text.Trim());
                    button.Text = "波特率: " + e.ClickedItem.Text;
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
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            tbxSend.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                //btnOpenCom_Click(null, null);
            }
            serialDataTransmission(tbxSend.Text);
        }

        public int hex2num(string Hexs, Byte[] Buff)
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
            while (checkBoxSendRegular.CheckState == CheckState.Checked)
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
                        Thread.Sleep(RegularCycle);
                    }
                    catch (Exception)
                    {

                    }
                } while (serialPort.BytesToWrite > 0);
            }
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
    }
}
