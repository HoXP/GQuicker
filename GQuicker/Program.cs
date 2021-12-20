using System;
using System.Threading;
using System.Windows.Forms;

namespace GQuicker
{
    static class Program
    {
        public static EventWaitHandle ProgramStarted;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isOnly;
            ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "OnlyStartEvent", out isOnly);
            if (!isOnly)
            {// 如果该命名事件已经存在（存在有前一个运行实例）则发事件通知并退出
                ProgramStarted.Set();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException); //处理未捕获的异常
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException); //处理UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException); //处理非UI线程异常
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            Application.Run(new frmMain());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogSingleton.Instance.Fatal("### Application_ThreadException.");
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogSingleton.Instance.Fatal("### CurrentDomain_UnhandledException.");
        }
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            LogSingleton.Instance.Fatal("### Application_ApplicationExit.");
        }
    }
}
