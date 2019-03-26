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
 * │CreatTime	: 2019/3/13 10:32:22													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusTools.Config
{
    public class SmtpSection : ConfigurationSection
    {
        public override bool IsReadOnly()
        {
            return base.IsReadOnly();
        }

        [ConfigurationProperty(
            "host",IsRequired =true,
            DefaultValue = "smtp.163.com"
            )]
        public string Host
        {
            get
            {
                return this["host"] as string;
            }
        }

        [ConfigurationProperty(
            "email",IsRequired =true
            )]
        [RegexStringValidator(
            @" ^ ([/ w -/.] +)@((/[[0 - 9]{1, 3}/.[0-9] {1,3}/.[0-9]{1,3}/.)|(([/ w -]+/.)+))([a - zA - Z]{2,4}|[0-9]{1,3})(/)?]$")]
        public string Email
        {
            get
            {
                return this["email"] as string;
            }
        }
        [ConfigurationProperty(
            "pass"
            )]
        public string Password
        {
            get
            {
                return this["pass"] as string;
            }
        }
    }
}
