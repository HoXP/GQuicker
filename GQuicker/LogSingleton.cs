using System.Windows.Forms;

namespace GQuicker
{
    class LogSingleton : ASingleton<LogSingleton>
    {
        private LogSingleton() { }

        public TextBox TxbLog { get; private set; } = null;

        public void Init(TextBox txbLog)
        {
            TxbLog = txbLog;
        }

        public void Log(string str)
        {
            TxbLog.AppendText("\r\n");
            TxbLog.AppendText(str);
        }
        public void Fatal(string str)
        {
            TxbLog.AppendText("\r\n");
            TxbLog.AppendText(string.Format($"[fatal]{str}"));
        }
    }
}