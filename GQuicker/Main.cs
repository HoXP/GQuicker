using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GQuicker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LogSingleton.Instance.Init(txbLog);
            BranchDataSingleton.Instance.Init();
            chkAutoStart.Checked = ToolsSingleton.Instance.IsAutoStart();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Hotkey hotkey = new Hotkey(Handle);
            Hotkey.HKShowHideMain = hotkey.RegisterHotkey(Keys.None, Hotkey.KeyFlags.MOD_CONTROL);
            hotkey.OnHotkey += new HotkeyEventHandler(OnHotkey);
        }

        private void tabMain_Enter(object sender, EventArgs e)
        {
            Dictionary<string, Branch> dict = BranchDataSingleton.Instance.DictBranch;
            if (dict == null)
            {
                LogSingleton.Instance.Fatal("### BranchDataSingleton.Instance.DictBranch is null.");
                return;
            }
            floServer.Controls.Clear();
            int i = 0;
            foreach (KeyValuePair<string, Branch> kv in dict)
            {
                Branch branch = kv.Value;
                RadioButton rto = new RadioButton();
                rto.Name = branch.Name;
                rto.Text = branch.Name;
                rto.CheckedChanged += Rto_CheckedChanged;
                floServer.Controls.Add(rto);
                if (i++ == 0)
                {
                    rto.Checked = true;
                }
            }
        }
        private void Rto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rto = sender as RadioButton;
            BranchDataSingleton.Instance.CurBranch = rto.Name;
        }

        #region buttons
        private void btnKillServer_Click(object sender, EventArgs e)
        {
            ProcessSingleton.Instance.KillProcess("svc_launch_d");
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnKillServer_Click(sender, e);
            string path = BranchDataSingleton.Instance.GetStartServerBatFullPath();
            ProcessSingleton.Instance.OpenDirectory(path);
        }
        private void btnOpenSln_Click(object sender, EventArgs e)
        {
            string path = BranchDataSingleton.Instance.GetSlnFullPath();
            ProcessSingleton.Instance.OpenDirectory(path);
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            string path = BranchDataSingleton.Instance.GetConfigFullPath();
            ProcessSingleton.Instance.OpenDirectory(path);
        }
        private void btnTexture_Click(object sender, EventArgs e)
        {
            string path = BranchDataSingleton.Instance.GetTextureFullPath();
            ProcessSingleton.Instance.OpenDirectory(path);
        }
        private void btnCrossplatform_Click(object sender, EventArgs e)
        {
            string path = BranchDataSingleton.Instance.GetCrossplatformFullPath();
            ProcessSingleton.Instance.OpenDirectory(path);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txbLog.Clear();
        }
        #endregion

        #region 托盘
        private void ntfATS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowHideFrmMain(true);
            }
        }
        private void ctmItemQuit_Click(object sender, EventArgs e)
        {// 托盘右键退出程序
            Dispose();
            Close();
        }
        #endregion

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {//设置开机自启动
            ToolsSingleton.Instance.AutoStart(chkAutoStart.Checked);
        }

        private void ShowHideFrmMain(bool isShow)
        {
            if (isShow)
            {
                if (!Visible)
                {
                    Visible = true;
                    Activate(); //激活窗体并给予它焦点
                }
            }
            else
            {
                if (Visible)
                {
                    Visible = false;
                }
            }
        }
        public void OnHotkey(int HotkeyID)
        {
            if (HotkeyID == Hotkey.HKShowHideMain)
            {
                if (Visible)
                {
                    ShowHideFrmMain(false);
                }
                else
                {
                    ShowHideFrmMain(true);
                }
            }
        }

        protected override void WndProc(ref Message msg)
        {//重写关闭窗口逻辑，关闭窗口不会退出，而是会隐藏
            const int WM_SYSCOMMAND = 0x112; //命令操作
            const int SC_CLOSE = 0xF060; //命令类型
            if (msg.Msg == WM_SYSCOMMAND && (int)msg.WParam == SC_CLOSE)
            {
                ShowHideFrmMain(false);
                return;
            }
            base.WndProc(ref msg);
        }
    }
}