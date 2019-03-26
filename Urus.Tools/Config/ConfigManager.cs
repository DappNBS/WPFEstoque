using System;
using System.Configuration;
using UrusTools.Config;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: TerzoChat.Config
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/13 13:53:36													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusTools.Config
{
    public class ConfigManager
    {
        const string CLR_APP_CONF = "cli.conf";
        const string DEF_AVATAR = "/avatars/logo.png";
        private ConfigManager()
        {

        }

        public string AvatarLocal()
        {
            return DEF_AVATAR;
        }

        public static ConfigManager Instance
        {
            get
            {
                return Nested.Instace;
            }
        }

        class Nested
        {
            static Nested()
            {

            }
            internal static readonly ConfigManager Instace = new ConfigManager();
        }

        public T GetConfigSection<T>(string section) 
            where T : System.Configuration.ConfigurationSection
        {
            if (section == null || section.Length == 0) return null;
            object o = ConfigurationManager.GetSection(section);
            return o==null? null: o as T;
        }
        public T GetConfigSection<T>(SectionType type)
            where T : System.Configuration.ConfigurationSection
        {
            return GetConfigSection<T>(type.ToString());
        }

        public bool BackProcess()
        {
            GRPCConfSection section = GetConfigSection<GRPCConfSection>(SectionType.gRPCServer);
            if (section == null) return true;
            return section.BackProcess;
        }
    }
}
