using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace GQuicker
{
    class BranchDataSingleton : ASingleton<BranchDataSingleton>
    {
        internal Dictionary<string, Branch> DictBranch { get; private set; } = new Dictionary<string, Branch>();
        internal string CurBranch { get; set; } = string.Empty;

        private BranchDataSingleton() { }

        public void Init()
        {
            DictBranch.Clear();
            
            ConfigurationSectionCollection sectionsBranches = ConfigHelper.GetBranchSectionCollection();
            foreach (ConfigurationSection section in sectionsBranches)
            {
                string sectionName = section.SectionInformation.Name;
                object o = ConfigurationManager.GetSection(string.Format($"{ConfigHelper.BranchGroupName}/{sectionName}"));
                if(o == null)
                {
                    LogSingleton.Instance.Fatal($"### Section [{sectionName}] null.");
                    continue;
                }
                NameValueCollection nvc = o as NameValueCollection;
                string name = nvc["Name"];
                string path = nvc["Path"];
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(path))
                {
                    LogSingleton.Instance.Fatal($"### no key [{name}] or [{path}].");
                    continue;
                }
                Branch branch = new Branch(sectionName, name, path);
                DictBranch.Add(name, branch);
                LogSingleton.Instance.Log($"### add [{sectionName}] [{name}] [{path}].");
            }
        }

        public Branch GetBranch(string name)
        {
            if (DictBranch != null && DictBranch.Count > 0 && DictBranch.ContainsKey(name))
            {
                return DictBranch[name];
            }
            return null;
        }
        
        public string GetBranchMatchsrpgPath(string name)
        {
            Branch branch = GetBranch(name);
            if (branch != null)
            {
                string depot_matchsrpgPath = GetAppSettingValue("depot_matchsrpgPath");
                string matchsrpgPath = GetAppSettingValue("matchsrpgPath");
                return string.Format($"{branch.DiskPath}{depot_matchsrpgPath}{matchsrpgPath}{branch.Path}") ;
            }
            return null;
        }
        public string GetBranchMrPath(string name)
        {
            Branch branch = GetBranch(name);
            if (branch != null)
            {
                string depot_matchsrpgPath = GetAppSettingValue("depot_matchsrpgPath");
                string mrPath = GetAppSettingValue("mrPath");
                return string.Format($"{branch.DiskPath}{depot_matchsrpgPath}{mrPath}{branch.Path}");
            }
            return null;
        }

        internal string GetAppSettingValue(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value;
        }

        internal string GetSlnFullPath()
        {
            string branchMatchsrpgPath = GetBranchMatchsrpgPath(CurBranch);
            string path = GetAppSettingValue("SlnPath");
            return string.Format($"{branchMatchsrpgPath}{path}");
        }
        internal string GetStartServerBatFullPath()
        {
            string branchMatchsrpgPath = GetBranchMatchsrpgPath(CurBranch);
            string path = GetAppSettingValue("StartServerBatPath");
            return string.Format($"{branchMatchsrpgPath}{path}");
        }
        internal string GetConfigFullPath()
        {
            string branchMatchsrpgPath = GetBranchMatchsrpgPath(CurBranch);
            string path = GetAppSettingValue("xls_configPath");
            return string.Format($"{branchMatchsrpgPath}{path}");
        }
        internal string GetTextureFullPath()
        {
            string branchMatchsrpgPath = GetBranchMrPath(CurBranch);
            string path = GetAppSettingValue("texturePath");
            return string.Format($"{branchMatchsrpgPath}{path}");
        }
        internal string GetCrossplatformFullPath()
        {
            string branchMatchsrpgPath = GetBranchMrPath(CurBranch);
            string path = GetAppSettingValue("crossplatformPath");
            return string.Format($"{branchMatchsrpgPath}{path}");
        }
    }

    class Branch
    {
        public string SectionName { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public string DiskPath { get; private set; } = string.Empty;
        public string Path { get; private set; } = string.Empty;

        private Branch() { }
        public Branch(string sectionName, string name, string path)
        {
            SectionName = sectionName;
            Name = name;
            string[] s = path.Split(';');
            DiskPath = s[0];
            Path = s[1];
        }
    }
}