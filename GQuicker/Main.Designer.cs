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
            this.btnCrossplatform = new System.Windows.Forms.Button();
            this.btnTexture = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnKillServer = new System.Windows.Forms.Button();
            this.floServer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenSln = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
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
            this.tabpSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctmATS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpBranch
            // 
            this.tabpBranch.Controls.Add(this.btnCrossplatform);
            this.tabpBranch.Controls.Add(this.btnTexture);
            this.tabpBranch.Controls.Add(this.btnConfig);
            this.tabpBranch.Controls.Add(this.btnKillServer);
            this.tabpBranch.Controls.Add(this.floServer);
            this.tabpBranch.Controls.Add(this.btnOpenSln);
            this.tabpBranch.Controls.Add(this.btnStartServer);
            this.tabpBranch.Location = new System.Drawing.Point(4, 22);
            this.tabpBranch.Name = "tabpBranch";
            this.tabpBranch.Padding = new System.Windows.Forms.Padding(3);
            this.tabpBranch.Size = new System.Drawing.Size(352, 382);
            this.tabpBranch.TabIndex = 0;
            this.tabpBranch.Text = "Branch";
            this.tabpBranch.UseVisualStyleBackColor = true;
            // 
            // btnCrossplatform
            // 
            this.btnCrossplatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrossplatform.Location = new System.Drawing.Point(173, 341);
            this.btnCrossplatform.Name = "btnCrossplatform";
            this.btnCrossplatform.Size = new System.Drawing.Size(172, 30);
            this.btnCrossplatform.TabIndex = 7;
            this.btnCrossplatform.Text = "crossplatform";
            this.btnCrossplatform.UseVisualStyleBackColor = true;
            this.btnCrossplatform.Click += new System.EventHandler(this.btnCrossplatform_Click);
            // 
            // btnTexture
            // 
            this.btnTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTexture.Location = new System.Drawing.Point(8, 341);
            this.btnTexture.Name = "btnTexture";
            this.btnTexture.Size = new System.Drawing.Size(159, 30);
            this.btnTexture.TabIndex = 6;
            this.btnTexture.Text = "texture";
            this.btnTexture.UseVisualStyleBackColor = true;
            this.btnTexture.Click += new System.EventHandler(this.btnTexture_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.Location = new System.Drawing.Point(8, 305);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(337, 30);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnKillServer
            // 
            this.btnKillServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillServer.BackColor = System.Drawing.Color.Transparent;
            this.btnKillServer.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillServer.ForeColor = System.Drawing.Color.Red;
            this.btnKillServer.Location = new System.Drawing.Point(8, 234);
            this.btnKillServer.Name = "btnKillServer";
            this.btnKillServer.Size = new System.Drawing.Size(337, 30);
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
            this.floServer.Size = new System.Drawing.Size(339, 221);
            this.floServer.TabIndex = 3;
            // 
            // btnOpenSln
            // 
            this.btnOpenSln.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSln.Location = new System.Drawing.Point(173, 269);
            this.btnOpenSln.Name = "btnOpenSln";
            this.btnOpenSln.Size = new System.Drawing.Size(172, 30);
            this.btnOpenSln.TabIndex = 1;
            this.btnOpenSln.Text = "sln";
            this.btnOpenSln.UseVisualStyleBackColor = true;
            this.btnOpenSln.Click += new System.EventHandler(this.btnOpenSln_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartServer.Location = new System.Drawing.Point(8, 269);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(159, 30);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "restart";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabpBranch);
            this.tabMain.Controls.Add(this.tabpSetting);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(360, 408);
            this.tabMain.TabIndex = 1;
            this.tabMain.Enter += new System.EventHandler(this.tabMain_Enter);
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
            this.tabpSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ctmATS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabpBranch;
        private System.Windows.Forms.Button btnOpenSln;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.FlowLayoutPanel floServer;
        private System.Windows.Forms.Button btnKillServer;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnTexture;
        private System.Windows.Forms.NotifyIcon ntfATS;
        private System.Windows.Forms.ContextMenuStrip ctmATS;
        private System.Windows.Forms.ToolStripMenuItem ctmItemQuit;
        private System.Windows.Forms.Button btnCrossplatform;
        private System.Windows.Forms.TabPage tabpSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Button btnClearLog;
    }
}

