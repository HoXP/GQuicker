using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace GQuicker
{
    class ToolsSingleton : ASingleton<ToolsSingleton>
    {
        private ToolsSingleton() { }
        private string autoRunKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// 是否自动启动
        /// </summary>
        internal bool IsAutoStart()
        {
            try
            {
                RegistryKey rkCurrentUser = Registry.CurrentUser;
                RegistryKey rkRun = rkCurrentUser.CreateSubKey(autoRunKey);
                string autoRunValue = rkRun.GetValue(Const.AppName) as string;
                rkRun.Close();
                rkCurrentUser.Close();
                if (string.IsNullOrEmpty(autoRunValue))
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                LogSingleton.Instance.Fatal("您需要管理员权限修改");
                return false;
            }
        }
        /// <summary>  
        /// 修改程序在注册表中的键值
        /// </summary>  
        /// <param name="isAuto">true:开机启动,false:不开机自启</param> 
        internal void AutoStart(bool isAuto = true)
        {
            try
            {
                RegistryKey rkCurrentUser = Registry.CurrentUser;
                RegistryKey rkRun = rkCurrentUser.CreateSubKey(autoRunKey);
                if (isAuto)
                {
                    rkRun.SetValue(Const.AppName, Application.ExecutablePath);
                }
                else
                {
                    rkRun.DeleteValue(Const.AppName, false);
                }
                rkRun.Close();
                rkCurrentUser.Close();
            }
            catch (Exception)
            {
                LogSingleton.Instance.Fatal("您需要管理员权限修改");
            }
        }
    }
}