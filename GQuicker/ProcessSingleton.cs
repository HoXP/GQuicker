using System.Diagnostics;

namespace GQuicker
{
    class ProcessSingleton : ASingleton<ProcessSingleton>
    {
        private ProcessSingleton() { }
        
        public void OpenDirectory(string path)
        {
            Process.Start("explorer.exe", path);
        }

        internal void KillProcess(string processName)
        {
            try
            {
                Process[] ps = Process.GetProcessesByName(processName);
                if(ps != null && ps.Length > 0)
                {
                    for (int i = 0; i < ps.Length; i++)
                    {
                        Process p = ps[i];
                        p.Kill();
                    }
                }
                else
                {
                    LogSingleton.Instance.Log($"未找到进程[{processName}]");
                }
            }
            catch
            {
                LogSingleton.Instance.Fatal($"无法关闭进程[{processName}]");
            }
        }
    }
}