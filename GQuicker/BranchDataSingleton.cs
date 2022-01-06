using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace GQuicker
{
    class BranchDataSingleton : ASingleton<BranchDataSingleton>
    {
        internal Dictionary<string, Branch> DictBranch { get; private set; } = new Dictionary<string, Branch>();
        internal Dictionary<string, BranchButton> DictBranchButton { get; private set; } = new Dictionary<string, BranchButton>();
        internal string CurBranch { get; set; } = string.Empty;

        private BranchDataSingleton() { }

        public void Init()
        {
            DictBranch.Clear();
            //分支
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
                string disk = nvc["Disk"];
                string path = nvc["Path"];
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(path))
                {
                    LogSingleton.Instance.Fatal($"### no key [{name}] or [{path}].");
                    continue;
                }
                Branch branch = new Branch(sectionName, name, disk, path);
                DictBranch.Add(name, branch);
            }
            //分支按钮
            ConfigurationSectionCollection sectionsBranchButtons = ConfigHelper.GetBranchButtonSectionCollection();
            foreach (ConfigurationSection section in sectionsBranchButtons)
            {
                string sectionName = section.SectionInformation.Name;
                object o = ConfigurationManager.GetSection(string.Format($"{ConfigHelper.BranchButtonGroupName}/{sectionName}"));
                if (o == null)
                {
                    LogSingleton.Instance.Fatal($"### Section [{sectionName}] null.");
                    continue;
                }
                NameValueCollection nvc = o as NameValueCollection;
                string name = nvc["Name"];
                string matchsrpgOrMr = nvc["MatchsrpgOrMr"];
                string path = nvc["Path"];
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(matchsrpgOrMr) || string.IsNullOrEmpty(path))
                {
                    LogSingleton.Instance.Fatal($"### no key [{name}] or [{matchsrpgOrMr}] or [{path}].");
                    continue;
                }
                BranchButton bb = new BranchButton(sectionName, name, matchsrpgOrMr, path);
                DictBranchButton.Add(name, bb);
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
        
        public string GetBranchMatchsrpgOrMrPath(string name, string matchsrpgOrMr)
        {
            Branch branch = GetBranch(name);
            if (branch != null)
            {
                string depot_matchsrpgPath = ConfigHelper.GetAppSettingValue("depot_matchsrpgPath");
                string matchsrpgOrMrPath = ConfigHelper.GetAppSettingValue(matchsrpgOrMr);
                return string.Format($"{branch.Disk}{depot_matchsrpgPath}{matchsrpgOrMrPath}{branch.Path}");
            }
            return null;
        }
    }

    class Branch
    {
        public string SectionName { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public string Disk { get; private set; } = string.Empty;
        public string Path { get; private set; } = string.Empty;

        private Branch() { }
        public Branch(string sectionName, string name, string disk, string path)
        {
            SectionName = sectionName;
            Name = name;
            Disk = disk;
            Path = path;
        }
    }
    class BranchButton
    {
        public string SectionName { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public string MatchsrpgOrMr { get; private set; } = string.Empty;
        public string Path { get; private set; } = string.Empty;

        private BranchButton() { }
        public BranchButton(string sectionName, string name, string matchsrpgOrMr, string path)
        {
            SectionName = sectionName;
            Name = name;
            MatchsrpgOrMr = matchsrpgOrMr;
            Path = path;
        }
    }
}