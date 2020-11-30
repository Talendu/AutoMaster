namespace AutoMaster
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FIle_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FIle_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Setting_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCom = new System.Windows.Forms.TabPage();
            this.GBoxSendData = new System.Windows.Forms.GroupBox();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.tbxCycle = new System.Windows.Forms.TextBox();
            this.checkBoxSendNewLine = new System.Windows.Forms.CheckBox();
            this.checkBoxSendHex = new System.Windows.Forms.CheckBox();
            this.checkBoxSendRegular = new System.Windows.Forms.CheckBox();
            this.LabelCycle = new System.Windows.Forms.Label();
            this.GBoxMessageView = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.checkBoxTimeStamp = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSend = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoNewLine = new System.Windows.Forms.CheckBox();
            this.checkBoxShowInHex = new System.Windows.Forms.CheckBox();
            this.tbxReceiveCount = new System.Windows.Forms.TextBox();
            this.LabelReceiveCount = new System.Windows.Forms.Label();
            this.tbxSendCount = new System.Windows.Forms.TextBox();
            this.LabelSendCount = new System.Windows.Forms.Label();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.tabPageParamShow = new System.Windows.Forms.TabPage();
            this.listView_State = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_param = new System.Windows.Forms.DataGridView();
            this.paramDataView_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataView_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataView_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataView_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataView_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_di = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_do = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnStopSendFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.LabelProtocol = new System.Windows.Forms.Label();
            this.cbxProtocol = new System.Windows.Forms.ComboBox();
            this.pgrsBarSendPgrs = new System.Windows.Forms.ProgressBar();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_eepromParam_save = new System.Windows.Forms.Button();
            this.btn_eepromParam_stop = new System.Windows.Forms.Button();
            this.btn_eepromParam_send = new System.Windows.Forms.Button();
            this.btn_eepromParam_load = new System.Windows.Forms.Button();
            this.lab_eepromParam_progress = new System.Windows.Forms.Label();
            this.pb_eepromParam_progress = new System.Windows.Forms.ProgressBar();
            this.tb_eepromParam_file = new System.Windows.Forms.TextBox();
            this.dataGridView_paramEEPROM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_startCom = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip_Com = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_Baud = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_DataBits = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_StopBit = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_Parity = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_Enable = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCom.SuspendLayout();
            this.GBoxSendData.SuspendLayout();
            this.GBoxMessageView.SuspendLayout();
            this.tabPageParamShow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_param)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_di)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_do)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paramEEPROM)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Setting});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_FIle_Save,
            this.Menu_FIle_Open});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(44, 21);
            this.Menu_File.Text = "文件";
            // 
            // Menu_FIle_Save
            // 
            this.Menu_FIle_Save.Name = "Menu_FIle_Save";
            this.Menu_FIle_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_FIle_Save.Size = new System.Drawing.Size(147, 22);
            this.Menu_FIle_Save.Text = "保存";
            this.Menu_FIle_Save.Click += new System.EventHandler(this.Menu_File_Save_Click);
            // 
            // Menu_FIle_Open
            // 
            this.Menu_FIle_Open.Name = "Menu_FIle_Open";
            this.Menu_FIle_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Menu_FIle_Open.Size = new System.Drawing.Size(147, 22);
            this.Menu_FIle_Open.Text = "打开";
            this.Menu_FIle_Open.Click += new System.EventHandler(this.Menu_File_Open_Click);
            // 
            // Menu_Setting
            // 
            this.Menu_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Setting_Font});
            this.Menu_Setting.Name = "Menu_Setting";
            this.Menu_Setting.Size = new System.Drawing.Size(44, 21);
            this.Menu_Setting.Text = "设置";
            // 
            // Menu_Setting_Font
            // 
            this.Menu_Setting_Font.Name = "Menu_Setting_Font";
            this.Menu_Setting_Font.Size = new System.Drawing.Size(100, 22);
            this.Menu_Setting_Font.Text = "字体";
            this.Menu_Setting_Font.Click += new System.EventHandler(this.Menu_Setting_Font_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCom);
            this.tabControl1.Controls.Add(this.tabPageParamShow);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 473);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCom
            // 
            this.tabPageCom.Controls.Add(this.GBoxSendData);
            this.tabPageCom.Controls.Add(this.GBoxMessageView);
            this.tabPageCom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCom.Name = "tabPageCom";
            this.tabPageCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCom.Size = new System.Drawing.Size(752, 447);
            this.tabPageCom.TabIndex = 0;
            this.tabPageCom.Text = "通讯";
            this.tabPageCom.UseVisualStyleBackColor = true;
            // 
            // GBoxSendData
            // 
            this.GBoxSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBoxSendData.Controls.Add(this.btnClearSend);
            this.GBoxSendData.Controls.Add(this.btnSend);
            this.GBoxSendData.Controls.Add(this.tbxSend);
            this.GBoxSendData.Controls.Add(this.tbxCycle);
            this.GBoxSendData.Controls.Add(this.checkBoxSendNewLine);
            this.GBoxSendData.Controls.Add(this.checkBoxSendHex);
            this.GBoxSendData.Controls.Add(this.checkBoxSendRegular);
            this.GBoxSendData.Controls.Add(this.LabelCycle);
            this.GBoxSendData.Location = new System.Drawing.Point(4, 317);
            this.GBoxSendData.Name = "GBoxSendData";
            this.GBoxSendData.Size = new System.Drawing.Size(742, 124);
            this.GBoxSendData.TabIndex = 2;
            this.GBoxSendData.TabStop = false;
            this.GBoxSendData.Text = "数据发送";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearSend.Location = new System.Drawing.Point(661, 63);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 28);
            this.btnClearSend.TabIndex = 34;
            this.btnClearSend.Text = "清除发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.Location = new System.Drawing.Point(661, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 33;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxSend
            // 
            this.tbxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSend.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSend.Location = new System.Drawing.Point(8, 20);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSend.Size = new System.Drawing.Size(647, 71);
            this.tbxSend.TabIndex = 27;
            // 
            // tbxCycle
            // 
            this.tbxCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCycle.CausesValidation = false;
            this.tbxCycle.Location = new System.Drawing.Point(271, 97);
            this.tbxCycle.MaxLength = 10;
            this.tbxCycle.Name = "tbxCycle";
            this.tbxCycle.Size = new System.Drawing.Size(48, 21);
            this.tbxCycle.TabIndex = 29;
            this.tbxCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxSendNewLine
            // 
            this.checkBoxSendNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSendNewLine.AutoSize = true;
            this.checkBoxSendNewLine.Location = new System.Drawing.Point(80, 99);
            this.checkBoxSendNewLine.Name = "checkBoxSendNewLine";
            this.checkBoxSendNewLine.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSendNewLine.TabIndex = 31;
            this.checkBoxSendNewLine.Text = "发送新行";
            this.checkBoxSendNewLine.UseVisualStyleBackColor = true;
            this.checkBoxSendNewLine.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxSendHex
            // 
            this.checkBoxSendHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSendHex.AutoSize = true;
            this.checkBoxSendHex.Location = new System.Drawing.Point(8, 99);
            this.checkBoxSendHex.Name = "checkBoxSendHex";
            this.checkBoxSendHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxSendHex.TabIndex = 30;
            this.checkBoxSendHex.Text = "Hex发送";
            this.checkBoxSendHex.UseVisualStyleBackColor = true;
            this.checkBoxSendHex.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxSendRegular
            // 
            this.checkBoxSendRegular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSendRegular.AutoSize = true;
            this.checkBoxSendRegular.Location = new System.Drawing.Point(158, 99);
            this.checkBoxSendRegular.Name = "checkBoxSendRegular";
            this.checkBoxSendRegular.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSendRegular.TabIndex = 32;
            this.checkBoxSendRegular.Text = "定时发送";
            this.checkBoxSendRegular.UseVisualStyleBackColor = true;
            this.checkBoxSendRegular.CheckedChanged += new System.EventHandler(this.checkBoxSendRegular_CheckedChanged);
            // 
            // LabelCycle
            // 
            this.LabelCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCycle.AutoSize = true;
            this.LabelCycle.Location = new System.Drawing.Point(236, 100);
            this.LabelCycle.Name = "LabelCycle";
            this.LabelCycle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCycle.Size = new System.Drawing.Size(29, 12);
            this.LabelCycle.TabIndex = 28;
            this.LabelCycle.Text = "周期";
            // 
            // GBoxMessageView
            // 
            this.GBoxMessageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBoxMessageView.Controls.Add(this.btnClearData);
            this.GBoxMessageView.Controls.Add(this.checkBoxTimeStamp);
            this.GBoxMessageView.Controls.Add(this.checkBoxShowSend);
            this.GBoxMessageView.Controls.Add(this.checkBoxAutoNewLine);
            this.GBoxMessageView.Controls.Add(this.checkBoxShowInHex);
            this.GBoxMessageView.Controls.Add(this.tbxReceiveCount);
            this.GBoxMessageView.Controls.Add(this.LabelReceiveCount);
            this.GBoxMessageView.Controls.Add(this.tbxSendCount);
            this.GBoxMessageView.Controls.Add(this.LabelSendCount);
            this.GBoxMessageView.Controls.Add(this.tbxData);
            this.GBoxMessageView.Location = new System.Drawing.Point(6, 6);
            this.GBoxMessageView.Name = "GBoxMessageView";
            this.GBoxMessageView.Size = new System.Drawing.Size(740, 305);
            this.GBoxMessageView.TabIndex = 1;
            this.GBoxMessageView.TabStop = false;
            this.GBoxMessageView.Text = "数据显示";
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearData.Location = new System.Drawing.Point(659, 270);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 28);
            this.btnClearData.TabIndex = 0;
            this.btnClearData.Text = "清空数据";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // checkBoxTimeStamp
            // 
            this.checkBoxTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxTimeStamp.AutoSize = true;
            this.checkBoxTimeStamp.Location = new System.Drawing.Point(234, 278);
            this.checkBoxTimeStamp.Name = "checkBoxTimeStamp";
            this.checkBoxTimeStamp.Size = new System.Drawing.Size(60, 16);
            this.checkBoxTimeStamp.TabIndex = 31;
            this.checkBoxTimeStamp.Text = "时间戳";
            this.checkBoxTimeStamp.UseVisualStyleBackColor = true;
            this.checkBoxTimeStamp.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxShowSend
            // 
            this.checkBoxShowSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowSend.AutoSize = true;
            this.checkBoxShowSend.Checked = true;
            this.checkBoxShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSend.Location = new System.Drawing.Point(156, 277);
            this.checkBoxShowSend.Name = "checkBoxShowSend";
            this.checkBoxShowSend.Size = new System.Drawing.Size(72, 16);
            this.checkBoxShowSend.TabIndex = 31;
            this.checkBoxShowSend.Text = "显示发送";
            this.checkBoxShowSend.UseVisualStyleBackColor = true;
            this.checkBoxShowSend.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxAutoNewLine
            // 
            this.checkBoxAutoNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoNewLine.AutoSize = true;
            this.checkBoxAutoNewLine.Location = new System.Drawing.Point(78, 277);
            this.checkBoxAutoNewLine.Name = "checkBoxAutoNewLine";
            this.checkBoxAutoNewLine.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoNewLine.TabIndex = 30;
            this.checkBoxAutoNewLine.Text = "自动换行";
            this.checkBoxAutoNewLine.UseVisualStyleBackColor = true;
            this.checkBoxAutoNewLine.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxShowInHex
            // 
            this.checkBoxShowInHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowInHex.AutoSize = true;
            this.checkBoxShowInHex.Location = new System.Drawing.Point(6, 277);
            this.checkBoxShowInHex.Name = "checkBoxShowInHex";
            this.checkBoxShowInHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxShowInHex.TabIndex = 28;
            this.checkBoxShowInHex.Text = "Hex显示";
            this.checkBoxShowInHex.UseVisualStyleBackColor = true;
            this.checkBoxShowInHex.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tbxReceiveCount
            // 
            this.tbxReceiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxReceiveCount.CausesValidation = false;
            this.tbxReceiveCount.Location = new System.Drawing.Point(469, 275);
            this.tbxReceiveCount.Name = "tbxReceiveCount";
            this.tbxReceiveCount.ReadOnly = true;
            this.tbxReceiveCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxReceiveCount.Size = new System.Drawing.Size(48, 21);
            this.tbxReceiveCount.TabIndex = 27;
            // 
            // LabelReceiveCount
            // 
            this.LabelReceiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelReceiveCount.AutoSize = true;
            this.LabelReceiveCount.ForeColor = System.Drawing.Color.Blue;
            this.LabelReceiveCount.Location = new System.Drawing.Point(434, 278);
            this.LabelReceiveCount.Name = "LabelReceiveCount";
            this.LabelReceiveCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelReceiveCount.Size = new System.Drawing.Size(29, 12);
            this.LabelReceiveCount.TabIndex = 26;
            this.LabelReceiveCount.Text = "接收";
            // 
            // tbxSendCount
            // 
            this.tbxSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSendCount.CausesValidation = false;
            this.tbxSendCount.Location = new System.Drawing.Point(380, 275);
            this.tbxSendCount.Name = "tbxSendCount";
            this.tbxSendCount.ReadOnly = true;
            this.tbxSendCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSendCount.Size = new System.Drawing.Size(48, 21);
            this.tbxSendCount.TabIndex = 25;
            // 
            // LabelSendCount
            // 
            this.LabelSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSendCount.AutoSize = true;
            this.LabelSendCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelSendCount.Location = new System.Drawing.Point(345, 278);
            this.LabelSendCount.Name = "LabelSendCount";
            this.LabelSendCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSendCount.Size = new System.Drawing.Size(29, 12);
            this.LabelSendCount.TabIndex = 24;
            this.LabelSendCount.Text = "发送";
            // 
            // tbxData
            // 
            this.tbxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxData.Location = new System.Drawing.Point(7, 21);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.ReadOnly = true;
            this.tbxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxData.Size = new System.Drawing.Size(727, 243);
            this.tbxData.TabIndex = 32;
            // 
            // tabPageParamShow
            // 
            this.tabPageParamShow.Controls.Add(this.listView_State);
            this.tabPageParamShow.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamShow.Name = "tabPageParamShow";
            this.tabPageParamShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamShow.Size = new System.Drawing.Size(752, 447);
            this.tabPageParamShow.TabIndex = 1;
            this.tabPageParamShow.Text = "参数显示";
            this.tabPageParamShow.UseVisualStyleBackColor = true;
            // 
            // listView_State
            // 
            this.listView_State.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_State.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_State.FullRowSelect = true;
            this.listView_State.GridLines = true;
            this.listView_State.Location = new System.Drawing.Point(6, 6);
            this.listView_State.Name = "listView_State";
            this.listView_State.Size = new System.Drawing.Size(740, 413);
            this.listView_State.TabIndex = 0;
            this.listView_State.UseCompatibleStateImageBehavior = false;
            this.listView_State.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "参数";
            this.columnHeader2.Width = 255;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "值";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "单位";
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "描述";
            this.columnHeader5.Width = 263;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_param);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(752, 447);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "参数显示";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_param
            // 
            this.dataGridView_param.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_param.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_param.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramDataView_id,
            this.paramDataView_name,
            this.paramDataView_value,
            this.paramDataView_unit,
            this.paramDataView_description});
            this.dataGridView_param.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_param.Name = "dataGridView_param";
            this.dataGridView_param.RowTemplate.Height = 23;
            this.dataGridView_param.Size = new System.Drawing.Size(745, 419);
            this.dataGridView_param.TabIndex = 0;
            this.dataGridView_param.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_param_CellEndEdit);
            this.dataGridView_param.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView_param_SortCompare);
            // 
            // paramDataView_id
            // 
            this.paramDataView_id.HeaderText = "序号";
            this.paramDataView_id.Name = "paramDataView_id";
            this.paramDataView_id.ReadOnly = true;
            this.paramDataView_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramDataView_id.Width = 60;
            // 
            // paramDataView_name
            // 
            this.paramDataView_name.HeaderText = "名字";
            this.paramDataView_name.Name = "paramDataView_name";
            this.paramDataView_name.ReadOnly = true;
            this.paramDataView_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramDataView_name.Width = 200;
            // 
            // paramDataView_value
            // 
            this.paramDataView_value.HeaderText = "值";
            this.paramDataView_value.Name = "paramDataView_value";
            this.paramDataView_value.ReadOnly = true;
            this.paramDataView_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramDataView_value.Width = 80;
            // 
            // paramDataView_unit
            // 
            this.paramDataView_unit.HeaderText = "单位";
            this.paramDataView_unit.Name = "paramDataView_unit";
            this.paramDataView_unit.ReadOnly = true;
            this.paramDataView_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramDataView_unit.Width = 60;
            // 
            // paramDataView_description
            // 
            this.paramDataView_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paramDataView_description.HeaderText = "描述";
            this.paramDataView_description.Name = "paramDataView_description";
            this.paramDataView_description.ReadOnly = true;
            this.paramDataView_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramDataView_description.Width = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_di);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(752, 447);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "di";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_di
            // 
            this.dataGridView_di.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_di.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_di.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_di.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_di.Name = "dataGridView_di";
            this.dataGridView_di.RowTemplate.Height = 23;
            this.dataGridView_di.Size = new System.Drawing.Size(745, 419);
            this.dataGridView_di.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "名字";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "值";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "单位";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "描述";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 35;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_do);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 447);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "do";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_do
            // 
            this.dataGridView_do.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_do.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_do.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView_do.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_do.Name = "dataGridView_do";
            this.dataGridView_do.RowTemplate.Height = 23;
            this.dataGridView_do.Size = new System.Drawing.Size(745, 419);
            this.dataGridView_do.TabIndex = 2;
            this.dataGridView_do.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_param_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "序号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "名字";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "值";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "单位";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "描述";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 35;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnStopSendFile);
            this.tabPage4.Controls.Add(this.btnSendFile);
            this.tabPage4.Controls.Add(this.btnSendCmd);
            this.tabPage4.Controls.Add(this.btnOpenFile);
            this.tabPage4.Controls.Add(this.LabelProgress);
            this.tabPage4.Controls.Add(this.LabelProtocol);
            this.tabPage4.Controls.Add(this.cbxProtocol);
            this.tabPage4.Controls.Add(this.pgrsBarSendPgrs);
            this.tabPage4.Controls.Add(this.textBoxFileName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(752, 447);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "固件升级";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnStopSendFile
            // 
            this.btnStopSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStopSendFile.Location = new System.Drawing.Point(674, 390);
            this.btnStopSendFile.Name = "btnStopSendFile";
            this.btnStopSendFile.Size = new System.Drawing.Size(75, 28);
            this.btnStopSendFile.TabIndex = 27;
            this.btnStopSendFile.Text = "停止发送";
            this.btnStopSendFile.UseVisualStyleBackColor = true;
            this.btnStopSendFile.Click += new System.EventHandler(this.btnStopSendFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendFile.Location = new System.Drawing.Point(593, 390);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 28);
            this.btnSendFile.TabIndex = 26;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendCmd.Location = new System.Drawing.Point(512, 390);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(75, 28);
            this.btnSendCmd.TabIndex = 25;
            this.btnSendCmd.Text = "发送指令";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenFile.Location = new System.Drawing.Point(429, 390);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 28);
            this.btnOpenFile.TabIndex = 25;
            this.btnOpenFile.Text = "打开文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // LabelProgress
            // 
            this.LabelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Location = new System.Drawing.Point(510, 427);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelProgress.Size = new System.Drawing.Size(17, 12);
            this.LabelProgress.TabIndex = 29;
            this.LabelProgress.Text = "0%";
            // 
            // LabelProtocol
            // 
            this.LabelProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProtocol.AutoSize = true;
            this.LabelProtocol.Location = new System.Drawing.Point(535, 427);
            this.LabelProtocol.Name = "LabelProtocol";
            this.LabelProtocol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelProtocol.Size = new System.Drawing.Size(41, 12);
            this.LabelProtocol.TabIndex = 30;
            this.LabelProtocol.Text = "协议：";
            // 
            // cbxProtocol
            // 
            this.cbxProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProtocol.FormattingEnabled = true;
            this.cbxProtocol.Location = new System.Drawing.Point(582, 423);
            this.cbxProtocol.Name = "cbxProtocol";
            this.cbxProtocol.Size = new System.Drawing.Size(167, 20);
            this.cbxProtocol.TabIndex = 24;
            this.cbxProtocol.SelectedIndexChanged += new System.EventHandler(this.cbxProtocol_SelectedIndexChanged);
            // 
            // pgrsBarSendPgrs
            // 
            this.pgrsBarSendPgrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrsBarSendPgrs.Location = new System.Drawing.Point(3, 423);
            this.pgrsBarSendPgrs.Name = "pgrsBarSendPgrs";
            this.pgrsBarSendPgrs.Size = new System.Drawing.Size(501, 21);
            this.pgrsBarSendPgrs.Step = 1;
            this.pgrsBarSendPgrs.TabIndex = 28;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(3, 394);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileName.Size = new System.Drawing.Size(420, 21);
            this.textBoxFileName.TabIndex = 18;
            this.textBoxFileName.Text = "请打开文件";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_eepromParam_save);
            this.tabPage5.Controls.Add(this.btn_eepromParam_stop);
            this.tabPage5.Controls.Add(this.btn_eepromParam_send);
            this.tabPage5.Controls.Add(this.btn_eepromParam_load);
            this.tabPage5.Controls.Add(this.lab_eepromParam_progress);
            this.tabPage5.Controls.Add(this.pb_eepromParam_progress);
            this.tabPage5.Controls.Add(this.tb_eepromParam_file);
            this.tabPage5.Controls.Add(this.dataGridView_paramEEPROM);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 447);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "参数配置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_eepromParam_save
            // 
            this.btn_eepromParam_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eepromParam_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eepromParam_save.Location = new System.Drawing.Point(674, 382);
            this.btn_eepromParam_save.Name = "btn_eepromParam_save";
            this.btn_eepromParam_save.Size = new System.Drawing.Size(75, 28);
            this.btn_eepromParam_save.TabIndex = 36;
            this.btn_eepromParam_save.Text = "保存参数";
            this.btn_eepromParam_save.UseVisualStyleBackColor = true;
            this.btn_eepromParam_save.Click += new System.EventHandler(this.btn_eeprom_param_Click);
            // 
            // btn_eepromParam_stop
            // 
            this.btn_eepromParam_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eepromParam_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eepromParam_stop.Location = new System.Drawing.Point(674, 416);
            this.btn_eepromParam_stop.Name = "btn_eepromParam_stop";
            this.btn_eepromParam_stop.Size = new System.Drawing.Size(75, 28);
            this.btn_eepromParam_stop.TabIndex = 33;
            this.btn_eepromParam_stop.Text = "停止发送";
            this.btn_eepromParam_stop.UseVisualStyleBackColor = true;
            this.btn_eepromParam_stop.Click += new System.EventHandler(this.btn_eeprom_param_Click);
            // 
            // btn_eepromParam_send
            // 
            this.btn_eepromParam_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eepromParam_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eepromParam_send.Location = new System.Drawing.Point(593, 416);
            this.btn_eepromParam_send.Name = "btn_eepromParam_send";
            this.btn_eepromParam_send.Size = new System.Drawing.Size(75, 28);
            this.btn_eepromParam_send.TabIndex = 32;
            this.btn_eepromParam_send.Text = "发送参数";
            this.btn_eepromParam_send.UseVisualStyleBackColor = true;
            this.btn_eepromParam_send.Click += new System.EventHandler(this.btn_eeprom_param_Click);
            // 
            // btn_eepromParam_load
            // 
            this.btn_eepromParam_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eepromParam_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eepromParam_load.Location = new System.Drawing.Point(593, 382);
            this.btn_eepromParam_load.Name = "btn_eepromParam_load";
            this.btn_eepromParam_load.Size = new System.Drawing.Size(75, 28);
            this.btn_eepromParam_load.TabIndex = 31;
            this.btn_eepromParam_load.Text = "加载参数";
            this.btn_eepromParam_load.UseVisualStyleBackColor = true;
            this.btn_eepromParam_load.Click += new System.EventHandler(this.btn_eeprom_param_Click);
            // 
            // lab_eepromParam_progress
            // 
            this.lab_eepromParam_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_eepromParam_progress.Location = new System.Drawing.Point(558, 424);
            this.lab_eepromParam_progress.Name = "lab_eepromParam_progress";
            this.lab_eepromParam_progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_eepromParam_progress.Size = new System.Drawing.Size(29, 12);
            this.lab_eepromParam_progress.TabIndex = 35;
            this.lab_eepromParam_progress.Text = "0%";
            this.lab_eepromParam_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_eepromParam_progress
            // 
            this.pb_eepromParam_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_eepromParam_progress.Location = new System.Drawing.Point(4, 420);
            this.pb_eepromParam_progress.Name = "pb_eepromParam_progress";
            this.pb_eepromParam_progress.Size = new System.Drawing.Size(548, 21);
            this.pb_eepromParam_progress.Step = 1;
            this.pb_eepromParam_progress.TabIndex = 34;
            // 
            // tb_eepromParam_file
            // 
            this.tb_eepromParam_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_eepromParam_file.Location = new System.Drawing.Point(4, 386);
            this.tb_eepromParam_file.Name = "tb_eepromParam_file";
            this.tb_eepromParam_file.ReadOnly = true;
            this.tb_eepromParam_file.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_eepromParam_file.Size = new System.Drawing.Size(583, 21);
            this.tb_eepromParam_file.TabIndex = 30;
            this.tb_eepromParam_file.Text = "请打开文件";
            // 
            // dataGridView_paramEEPROM
            // 
            this.dataGridView_paramEEPROM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_paramEEPROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_paramEEPROM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView_paramEEPROM.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_paramEEPROM.Name = "dataGridView_paramEEPROM";
            this.dataGridView_paramEEPROM.RowTemplate.Height = 23;
            this.dataGridView_paramEEPROM.Size = new System.Drawing.Size(745, 373);
            this.dataGridView_paramEEPROM.TabIndex = 3;
            this.dataGridView_paramEEPROM.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_eepromParam_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "序号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "名字";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "值";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // btn_startCom
            // 
            this.btn_startCom.Location = new System.Drawing.Point(12, 28);
            this.btn_startCom.Name = "btn_startCom";
            this.btn_startCom.Size = new System.Drawing.Size(75, 28);
            this.btn_startCom.TabIndex = 1;
            this.btn_startCom.Text = "开始通信";
            this.btn_startCom.UseVisualStyleBackColor = true;
            this.btn_startCom.Click += new System.EventHandler(this.btn_startCom_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_Com,
            this.toolStripStatusLabel3,
            this.statusStrip_Baud,
            this.statusStrip_DataBits,
            this.statusStrip_StopBit,
            this.statusStrip_Parity,
            this.statusStrip_Enable});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStrip_Com
            // 
            this.statusStrip_Com.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_Com.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_Com.Name = "statusStrip_Com";
            this.statusStrip_Com.Size = new System.Drawing.Size(64, 21);
            this.statusStrip_Com.Text = "串口号: ";
            this.statusStrip_Com.ToolTipText = "串口号";
            this.statusStrip_Com.DropDownOpening += new System.EventHandler(this.statusStrip_Com_DropDownOpening);
            this.statusStrip_Com.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_DropDownItemClicked);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 18);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // statusStrip_Baud
            // 
            this.statusStrip_Baud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_Baud.Image = ((System.Drawing.Image)(resources.GetObject("statusStrip_Baud.Image")));
            this.statusStrip_Baud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_Baud.Name = "statusStrip_Baud";
            this.statusStrip_Baud.Size = new System.Drawing.Size(64, 21);
            this.statusStrip_Baud.Text = "波特率: ";
            this.statusStrip_Baud.ToolTipText = "波特率";
            this.statusStrip_Baud.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_DropDownItemClicked);
            // 
            // statusStrip_DataBits
            // 
            this.statusStrip_DataBits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_DataBits.Image = ((System.Drawing.Image)(resources.GetObject("statusStrip_DataBits.Image")));
            this.statusStrip_DataBits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_DataBits.Name = "statusStrip_DataBits";
            this.statusStrip_DataBits.Size = new System.Drawing.Size(64, 21);
            this.statusStrip_DataBits.Text = "数据位: ";
            this.statusStrip_DataBits.ToolTipText = "数据位";
            this.statusStrip_DataBits.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_DropDownItemClicked);
            // 
            // statusStrip_StopBit
            // 
            this.statusStrip_StopBit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_StopBit.Image = ((System.Drawing.Image)(resources.GetObject("statusStrip_StopBit.Image")));
            this.statusStrip_StopBit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_StopBit.Name = "statusStrip_StopBit";
            this.statusStrip_StopBit.Size = new System.Drawing.Size(64, 21);
            this.statusStrip_StopBit.Text = "停止位: ";
            this.statusStrip_StopBit.ToolTipText = "停止位";
            this.statusStrip_StopBit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_DropDownItemClicked);
            // 
            // statusStrip_Parity
            // 
            this.statusStrip_Parity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_Parity.Image = ((System.Drawing.Image)(resources.GetObject("statusStrip_Parity.Image")));
            this.statusStrip_Parity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_Parity.Name = "statusStrip_Parity";
            this.statusStrip_Parity.Size = new System.Drawing.Size(64, 21);
            this.statusStrip_Parity.Text = "校验位: ";
            this.statusStrip_Parity.ToolTipText = "校验位";
            this.statusStrip_Parity.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_DropDownItemClicked);
            // 
            // statusStrip_Enable
            // 
            this.statusStrip_Enable.ForeColor = System.Drawing.Color.Red;
            this.statusStrip_Enable.Image = global::AutoMaster.Properties.Resources.off;
            this.statusStrip_Enable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStrip_Enable.Name = "statusStrip_Enable";
            this.statusStrip_Enable.ShowDropDownArrow = false;
            this.statusStrip_Enable.Size = new System.Drawing.Size(52, 21);
            this.statusStrip_Enable.Text = "关闭";
            this.statusStrip_Enable.ToolTipText = "关闭串口";
            this.statusStrip_Enable.Click += new System.EventHandler(this.statusStrip_Enable_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "log files|*.log|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.log";
            this.openFileDialog.Filter = "log files|*.log|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_startCom);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "MainForm";
            this.Text = "AutoMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCom.ResumeLayout(false);
            this.GBoxSendData.ResumeLayout(false);
            this.GBoxSendData.PerformLayout();
            this.GBoxMessageView.ResumeLayout(false);
            this.GBoxMessageView.PerformLayout();
            this.tabPageParamShow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_param)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_di)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_do)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paramEEPROM)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_FIle_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting;
        private System.Windows.Forms.ToolStripMenuItem Menu_FIle_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting_Font;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCom;
        private System.Windows.Forms.TabPage tabPageParamShow;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_Com;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox GBoxSendData;
        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.TextBox tbxCycle;
        private System.Windows.Forms.CheckBox checkBoxSendNewLine;
        private System.Windows.Forms.CheckBox checkBoxSendHex;
        private System.Windows.Forms.CheckBox checkBoxSendRegular;
        private System.Windows.Forms.Label LabelCycle;
        private System.Windows.Forms.GroupBox GBoxMessageView;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.CheckBox checkBoxShowSend;
        private System.Windows.Forms.CheckBox checkBoxAutoNewLine;
        private System.Windows.Forms.CheckBox checkBoxShowInHex;
        private System.Windows.Forms.TextBox tbxReceiveCount;
        private System.Windows.Forms.Label LabelReceiveCount;
        private System.Windows.Forms.TextBox tbxSendCount;
        private System.Windows.Forms.Label LabelSendCount;
        private System.Windows.Forms.ListView listView_State;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_Baud;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_DataBits;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_StopBit;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_Parity;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_Enable;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_param;
        private System.Windows.Forms.Button btn_startCom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_di;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView_do;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataView_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataView_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataView_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataView_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataView_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.CheckBox checkBoxTimeStamp;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnStopSendFile;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label LabelProgress;
        private System.Windows.Forms.Label LabelProtocol;
        private System.Windows.Forms.ComboBox cbxProtocol;
        private System.Windows.Forms.ProgressBar pgrsBarSendPgrs;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView_paramEEPROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btn_eepromParam_stop;
        private System.Windows.Forms.Button btn_eepromParam_send;
        private System.Windows.Forms.Button btn_eepromParam_load;
        private System.Windows.Forms.Label lab_eepromParam_progress;
        private System.Windows.Forms.ProgressBar pb_eepromParam_progress;
        private System.Windows.Forms.TextBox tb_eepromParam_file;
        private System.Windows.Forms.Button btn_eepromParam_save;
    }
}

