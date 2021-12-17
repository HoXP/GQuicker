namespace GQuicker
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabpBranch = new System.Windows.Forms.TabPage();
            this.btnKillServer = new System.Windows.Forms.Button();
            this.floServer = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpOpen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabpSetting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.ntfATS = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmATS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tabpBranch.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabpOpen.SuspendLayout();
            this.tabpSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctmATS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpBranch
            // 
            this.tabpBranch.Controls.Add(this.btnKillServer);
            this.tabpBranch.Controls.Add(this.floServer);
            this.tabpBranch.Location = new System.Drawing.Point(4, 22);
            this.tabpBranch.Name = "tabpBranch";
            this.tabpBranch.Padding = new System.Windows.Forms.Padding(3);
            this.tabpBranch.Size = new System.Drawing.Size(352, 382);
            this.tabpBranch.TabIndex = 0;
            this.tabpBranch.Text = "Branch";
            this.tabpBranch.UseVisualStyleBackColor = true;
            // 
            // btnKillServer
            // 
            this.btnKillServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillServer.BackColor = System.Drawing.Color.Transparent;
            this.btnKillServer.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillServer.ForeColor = System.Drawing.Color.Red;
            this.btnKillServer.Location = new System.Drawing.Point(7, 346);
            this.btnKillServer.Name = "btnKillServer";
            this.btnKillServer.Size = new System.Drawing.Size(339, 30);
            this.btnKillServer.TabIndex = 4;
            this.btnKillServer.Text = "KILL";
            this.btnKillServer.UseVisualStyleBackColor = false;
            this.btnKillServer.Click += new System.EventHandler(this.btnKillServer_Click);
            // 
            // floServer
            // 
            this.floServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floServer.Location = new System.Drawing.Point(7, 7);
            this.floServer.Name = "floServer";
            this.floServer.Size = new System.Drawing.Size(339, 333);
            this.floServer.TabIndex = 3;
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabpBranch);
            this.tabMain.Controls.Add(this.tabpOpen);
            this.tabMain.Controls.Add(this.tabpSetting);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(360, 408);
            this.tabMain.TabIndex = 1;
            this.tabMain.Enter += new System.EventHandler(this.tabMain_Enter);
            // 
            // tabpOpen
            // 
            this.tabpOpen.Controls.Add(this.tableLayoutPanel2);
            this.tabpOpen.Location = new System.Drawing.Point(4, 22);
            this.tabpOpen.Name = "tabpOpen";
            this.tabpOpen.Size = new System.Drawing.Size(352, 382);
            this.tabpOpen.TabIndex = 2;
            this.tabpOpen.Text = "Open";
            this.tabpOpen.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 382);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabpSetting
            // 
            this.tabpSetting.Controls.Add(this.tableLayoutPanel1);
            this.tabpSetting.Location = new System.Drawing.Point(4, 22);
            this.tabpSetting.Name = "tabpSetting";
            this.tabpSetting.Size = new System.Drawing.Size(352, 382);
            this.tabpSetting.TabIndex = 1;
            this.tabpSetting.Text = "Settings";
            this.tabpSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkAutoStart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(3, 3);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(96, 16);
            this.chkAutoStart.TabIndex = 0;
            this.chkAutoStart.Text = "开机自动启动";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // txbLog
            // 
            this.txbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLog.Location = new System.Drawing.Point(12, 449);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(360, 100);
            this.txbLog.TabIndex = 2;
            // 
            // ntfATS
            // 
            this.ntfATS.ContextMenuStrip = this.ctmATS;
            this.ntfATS.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfATS.Icon")));
            this.ntfATS.Text = "Assist Tools Set";
            this.ntfATS.Visible = true;
            this.ntfATS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfATS_MouseClick);
            // 
            // ctmATS
            // 
            this.ctmATS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmItemQuit});
            this.ctmATS.Name = "ctmATS";
            this.ctmATS.Size = new System.Drawing.Size(101, 26);
            // 
            // ctmItemQuit
            // 
            this.ctmItemQuit.Name = "ctmItemQuit";
            this.ctmItemQuit.Size = new System.Drawing.Size(100, 22);
            this.ctmItemQuit.Text = "退出";
            this.ctmItemQuit.Click += new System.EventHandler(this.ctmItemQuit_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(313, 426);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(59, 23);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assist Tools Set";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabpBranch.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabpOpen.ResumeLayout(false);
            this.tabpSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ctmATS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabpBranch;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.FlowLayoutPanel floServer;
        private System.Windows.Forms.Button btnKillServer;
        private System.Windows.Forms.NotifyIcon ntfATS;
        private System.Windows.Forms.ContextMenuStrip ctmATS;
        private System.Windows.Forms.ToolStripMenuItem ctmItemQuit;
        private System.Windows.Forms.TabPage tabpSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.TabPage tabpOpen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

