using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace GQuicker
{
    class OpenDataSingleton : ASingleton<OpenDataSingleton>
    {
        internal Dictionary<string, string> DictOpenButton { get; private set; } = new Dictionary<string, string>();
        internal string CurBranch { get; set; } = string.Empty;

        private OpenDataSingleton() { }

        public void Init()
        {
            DictOpenButton.Clear();
            ConfigurationSectionCollection sc = ConfigHelper.GetOpenSectionCollection();
            foreach (ConfigurationSection section in sc)
            {
                string sectionName = section.SectionInformation.Name;
                object o = ConfigurationManager.GetSection(string.Format($"{ConfigHelper.OpenGroupName}/{sectionName}"));
                if (o == null)
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
                DictOpenButton.Add(name, path);
            }
        }
    }
}