using System;
using System.Configuration;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UrusTools.Config
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/13 10:44:31													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusTools.Config
{
    public sealed class GRPCConfSection : ConfigurationSection
    {
        public GRPCConfSection()
        {

        }

        [ConfigurationProperty(
            "protocolType",IsRequired =true,
            DefaultValue ="protobuf"
            )]
        public string ProtocolType
        {
            get { return this["protocolType"] as string; }
        }

        [ConfigurationProperty(
            "host",DefaultValue ="127.0.0.1",
            IsRequired =true
            )]
        [RegexStringValidator(@"((25[0-5])|(2[0-4]\d)|(1\d\d)|([1-9]\d)|\d)(\.((25[0-5])|(2[0-4]\d)|(1\d\d)|([1-9]\d)|\d)){3}")]
        public string Host
        {
            get
            {
                return this["host"] as string;
            }
            set { this["host"] = value; }
        }

        /// <summary>
        /// NBS s
        /// </summary>
        [ConfigurationProperty(
            "port",DefaultValue =(int)10001,
            IsRequired =true)]
        [IntegerValidator(MinValue =10001,
            MaxValue =65535,ExcludeRange =false)]
        public int Port
        {
            get
            {
                return (int)this["port"] ;
            }
            set
            {
                this["port"] = value;
            }
        }

        [ConfigurationProperty("backProcess",
            DefaultValue =false)]
        public bool BackProcess
        {
            get { return (bool)this["backProcess"]; }
            set { this["backProcess"] = value; }
        }

    }
}
