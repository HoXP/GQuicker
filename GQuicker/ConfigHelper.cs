using System.Configuration;
using System.Windows.Forms;

namespace GQuicker
{
    class ConfigHelper
    {
        public static string BranchGroupName { get; } = "groupBranch";
        public static string BranchButtonGroupName { get; } = "groupBranchButtons";

        ///<summary>
        ///返回*.exe.config文件中appSettings配置节的value项
        ///</summary>
        ///<param name="strKey"></param>
        ///<returns></returns>
        public static string GetAppConfigValue(string strKey)
        {
            string val = ConfigurationManager.AppSettings[strKey];
            return val;
        }
        
        /// <summary>
        /// 获取GQuicker.exe.config
        /// </summary>
        /// <returns></returns>
        public static Configuration GetAppConfig()
        {
            Configuration exeConfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            ConfigurationFileMap configFile = new ConfigurationFileMap(exeConfig.FilePath);
            Configuration config = ConfigurationManager.OpenMappedMachineConfiguration(configFile);
            return config;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ConfigurationSectionCollection GetBranchSectionCollection()
        {
            Configuration config = GetAppConfig();
            ConfigurationSectionGroup branchesGroup = config.GetSectionGroup(BranchGroupName);
            ConfigurationSectionCollection sectionsBranches = branchesGroup.Sections;
            return sectionsBranches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ConfigurationSectionCollection GetBranchButtonSectionCollection()
        {
            Configuration config = GetAppConfig();
            ConfigurationSectionGroup branchesGroup = config.GetSectionGroup(BranchButtonGroupName);
            ConfigurationSectionCollection sectionsBranches = branchesGroup.Sections;
            return sectionsBranches;
        }
    }
}