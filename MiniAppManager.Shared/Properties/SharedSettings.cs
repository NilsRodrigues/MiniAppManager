﻿using System;
using System.Configuration;
using System.Collections;

namespace Bluegrams.Application.Properties
{
    internal class SharedSettings : ApplicationSettingsBase
    {

        private static SharedSettings defaultInstance = ((SharedSettings)(ApplicationSettingsBase.Synchronized(new SharedSettings())));

        public static SharedSettings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [UserScopedSetting()]
        [SettingsProvider(typeof(VariableSettingsProvider))]
        [DefaultSettingValue("")]
        [SettingsManageability(SettingsManageability.Roaming)]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        public Hashtable CustomSettings
        {
            get
            {
                return ((Hashtable)(this["CustomSettings"]));
            }
            set
            {
                this["CustomSettings"] = value;
            }
        }
    }
}
