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
            this.Menu_Setting_Com = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_VIew_Page = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View_Vertical = new System.Windows.Forms.ToolStripMenuItem();
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
            this.checkBoxShowSend = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoNewLine = new System.Windows.Forms.CheckBox();
            this.tbxData = new System.Windows.Forms.RichTextBox();
            this.checkBoxShowInHex = new System.Windows.Forms.CheckBox();
            this.tbxReceiveCount = new System.Windows.Forms.TextBox();
            this.LabelReceiveCount = new System.Windows.Forms.Label();
            this.tbxSendCount = new System.Windows.Forms.TextBox();
            this.LabelSendCount = new System.Windows.Forms.Label();
            this.tabPageParamShow = new System.Windows.Forms.TabPage();
            this.listView_State = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCom.SuspendLayout();
            this.GBoxSendData.SuspendLayout();
            this.GBoxMessageView.SuspendLayout();
            this.tabPageParamShow.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Setting,
            this.Menu_View});
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
            this.Menu_Setting_Com});
            this.Menu_Setting.Name = "Menu_Setting";
            this.Menu_Setting.Size = new System.Drawing.Size(44, 21);
            this.Menu_Setting.Text = "设置";
            // 
            // Menu_Setting_Com
            // 
            this.Menu_Setting_Com.Name = "Menu_Setting_Com";
            this.Menu_Setting_Com.Size = new System.Drawing.Size(124, 22);
            this.Menu_Setting_Com.Text = "串口配置";
            // 
            // Menu_View
            // 
            this.Menu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_VIew_Page,
            this.Menu_View_Vertical});
            this.Menu_View.Name = "Menu_View";
            this.Menu_View.Size = new System.Drawing.Size(44, 21);
            this.Menu_View.Text = "视图";
            // 
            // Menu_VIew_Page
            // 
            this.Menu_VIew_Page.Name = "Menu_VIew_Page";
            this.Menu_VIew_Page.Size = new System.Drawing.Size(124, 22);
            this.Menu_VIew_Page.Text = "分页";
            // 
            // Menu_View_Vertical
            // 
            this.Menu_View_Vertical.Checked = true;
            this.Menu_View_Vertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_View_Vertical.Name = "Menu_View_Vertical";
            this.Menu_View_Vertical.Size = new System.Drawing.Size(124, 22);
            this.Menu_View_Vertical.Text = "垂直分栏";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCom);
            this.tabControl1.Controls.Add(this.tabPageParamShow);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCom
            // 
            this.tabPageCom.Controls.Add(this.GBoxSendData);
            this.tabPageCom.Controls.Add(this.GBoxMessageView);
            this.tabPageCom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCom.Name = "tabPageCom";
            this.tabPageCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCom.Size = new System.Drawing.Size(752, 459);
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
            this.GBoxSendData.Location = new System.Drawing.Point(4, 340);
            this.GBoxSendData.Name = "GBoxSendData";
            this.GBoxSendData.Size = new System.Drawing.Size(742, 113);
            this.GBoxSendData.TabIndex = 2;
            this.GBoxSendData.TabStop = false;
            this.GBoxSendData.Text = "数据发送";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearSend.Location = new System.Drawing.Point(661, 52);
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
            this.tbxSend.Size = new System.Drawing.Size(647, 60);
            this.tbxSend.TabIndex = 27;
            // 
            // tbxCycle
            // 
            this.tbxCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCycle.CausesValidation = false;
            this.tbxCycle.Location = new System.Drawing.Point(271, 86);
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
            this.checkBoxSendNewLine.Location = new System.Drawing.Point(80, 88);
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
            this.checkBoxSendHex.Location = new System.Drawing.Point(8, 88);
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
            this.checkBoxSendRegular.Location = new System.Drawing.Point(158, 88);
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
            this.LabelCycle.Location = new System.Drawing.Point(236, 89);
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
            this.GBoxMessageView.Controls.Add(this.checkBoxShowSend);
            this.GBoxMessageView.Controls.Add(this.checkBoxAutoNewLine);
            this.GBoxMessageView.Controls.Add(this.tbxData);
            this.GBoxMessageView.Controls.Add(this.checkBoxShowInHex);
            this.GBoxMessageView.Controls.Add(this.tbxReceiveCount);
            this.GBoxMessageView.Controls.Add(this.LabelReceiveCount);
            this.GBoxMessageView.Controls.Add(this.tbxSendCount);
            this.GBoxMessageView.Controls.Add(this.LabelSendCount);
            this.GBoxMessageView.Location = new System.Drawing.Point(6, 6);
            this.GBoxMessageView.Name = "GBoxMessageView";
            this.GBoxMessageView.Size = new System.Drawing.Size(740, 328);
            this.GBoxMessageView.TabIndex = 1;
            this.GBoxMessageView.TabStop = false;
            this.GBoxMessageView.Text = "数据显示";
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearData.Location = new System.Drawing.Point(659, 293);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 28);
            this.btnClearData.TabIndex = 0;
            this.btnClearData.Text = "清空数据";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // checkBoxShowSend
            // 
            this.checkBoxShowSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowSend.AutoSize = true;
            this.checkBoxShowSend.Checked = true;
            this.checkBoxShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSend.Location = new System.Drawing.Point(156, 300);
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
            this.checkBoxAutoNewLine.Location = new System.Drawing.Point(78, 300);
            this.checkBoxAutoNewLine.Name = "checkBoxAutoNewLine";
            this.checkBoxAutoNewLine.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoNewLine.TabIndex = 30;
            this.checkBoxAutoNewLine.Text = "自动换行";
            this.checkBoxAutoNewLine.UseVisualStyleBackColor = true;
            this.checkBoxAutoNewLine.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tbxData
            // 
            this.tbxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxData.CausesValidation = false;
            this.tbxData.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxData.Location = new System.Drawing.Point(6, 20);
            this.tbxData.Name = "tbxData";
            this.tbxData.ReadOnly = true;
            this.tbxData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbxData.Size = new System.Drawing.Size(728, 267);
            this.tbxData.TabIndex = 29;
            this.tbxData.Text = "";
            // 
            // checkBoxShowInHex
            // 
            this.checkBoxShowInHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowInHex.AutoSize = true;
            this.checkBoxShowInHex.Location = new System.Drawing.Point(6, 300);
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
            this.tbxReceiveCount.Location = new System.Drawing.Point(358, 298);
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
            this.LabelReceiveCount.Location = new System.Drawing.Point(323, 301);
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
            this.tbxSendCount.Location = new System.Drawing.Point(269, 298);
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
            this.LabelSendCount.Location = new System.Drawing.Point(234, 301);
            this.LabelSendCount.Name = "LabelSendCount";
            this.LabelSendCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSendCount.Size = new System.Drawing.Size(29, 12);
            this.LabelSendCount.TabIndex = 24;
            this.LabelSendCount.Text = "发送";
            // 
            // tabPageParamShow
            // 
            this.tabPageParamShow.Controls.Add(this.listView_State);
            this.tabPageParamShow.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamShow.Name = "tabPageParamShow";
            this.tabPageParamShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamShow.Size = new System.Drawing.Size(752, 459);
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
            this.columnHeader4});
            this.listView_State.FullRowSelect = true;
            this.listView_State.GridLines = true;
            this.listView_State.Location = new System.Drawing.Point(6, 6);
            this.listView_State.Name = "listView_State";
            this.listView_State.Size = new System.Drawing.Size(740, 447);
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
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "值";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "单位";
            this.columnHeader4.Width = 146;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 516);
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
            this.ClientSize = new System.Drawing.Size(784, 539);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
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
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting_Com;
        private System.Windows.Forms.ToolStripMenuItem Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Menu_VIew_Page;
        private System.Windows.Forms.ToolStripMenuItem Menu_View_Vertical;
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
        private System.Windows.Forms.RichTextBox tbxData;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

