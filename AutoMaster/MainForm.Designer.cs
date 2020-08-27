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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FIle_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FIle_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Setting_Com = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_VIew_Page = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View_Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Setting,
            this.Menu_View});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_FIle_Save,
            this.Menu_FIle_Open});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(39, 21);
            this.Menu_File.Text = "File";
            // 
            // Menu_FIle_Save
            // 
            this.Menu_FIle_Save.Name = "Menu_FIle_Save";
            this.Menu_FIle_Save.Size = new System.Drawing.Size(108, 22);
            this.Menu_FIle_Save.Text = "Save";
            // 
            // Menu_FIle_Open
            // 
            this.Menu_FIle_Open.Name = "Menu_FIle_Open";
            this.Menu_FIle_Open.Size = new System.Drawing.Size(108, 22);
            this.Menu_FIle_Open.Text = "Open";
            // 
            // Menu_Setting
            // 
            this.Menu_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Setting_Com});
            this.Menu_Setting.Name = "Menu_Setting";
            this.Menu_Setting.Size = new System.Drawing.Size(60, 21);
            this.Menu_Setting.Text = "Setting";
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
            this.Menu_View.Size = new System.Drawing.Size(47, 21);
            this.Menu_View.Text = "View";
            // 
            // Menu_VIew_Page
            // 
            this.Menu_VIew_Page.Name = "Menu_VIew_Page";
            this.Menu_VIew_Page.Size = new System.Drawing.Size(119, 22);
            this.Menu_VIew_Page.Text = "Page";
            // 
            // Menu_View_Vertical
            // 
            this.Menu_View_Vertical.Checked = true;
            this.Menu_View_Vertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_View_Vertical.Name = "Menu_View_Vertical";
            this.Menu_View_Vertical.Size = new System.Drawing.Size(119, 22);
            this.Menu_View_Vertical.Text = "Vertical";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(179, 21);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 18);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainFram";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_FIle_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting;
        private System.Windows.Forms.ToolStripMenuItem Menu_FIle_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting_Com;
        private System.Windows.Forms.ToolStripMenuItem Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Menu_VIew_Page;
        private System.Windows.Forms.ToolStripMenuItem Menu_View_Vertical;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

