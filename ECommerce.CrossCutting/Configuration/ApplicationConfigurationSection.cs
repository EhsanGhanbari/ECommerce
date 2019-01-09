using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace ECommerce.CrossCutting.Configuration
{
    class ApplicationConfigurationSection : ConfigurationSection
    {
        #region Singletone

        static readonly Lazy<ApplicationConfigurationSection> _lazy = new Lazy<ApplicationConfigurationSection>(() =>
        {
            var section = new ApplicationConfigurationSection();
            if (File.Exists("Config.xml"))
            {
                using (var sr = new StreamReader("Config.xml"))
                {
                    using (var reader = new XmlTextReader(new StringReader(sr.ReadToEnd())))
                    {
                        section.DeserializeSection(reader);
                    }
                }
            }
            else
            {
                var xml = XmlWriter.Create("Config.xml");
                var xmlText = section.SerializeSection(new ApplicationConfigurationSection(), "AppConfig", ConfigurationSaveMode.Full);
                xml.WriteRaw(Environment.NewLine + xmlText);
                xml.Flush();
            }

            return section;
        });

        public static ApplicationConfigurationSection Current
        {
            get { return _lazy.Value; }
        }

        #endregion

        #region Properties

        [ConfigurationProperty("Value", DefaultValue = 0)]
        public int Value
        {
            get { return (int)this["Value"]; }
            set { this["Value"] = value; }
        }

        [ConfigurationProperty("Entity")]
        public EntityConfigurationElement Entity
        {
            get { return (EntityConfigurationElement)this["Entity"]; }
            set { this["Entity"] = value; }
        }

        #endregion
    }

    class EntityConfigurationElement : ConfigurationElement
    {
        #region Properties

        [ConfigurationProperty("Name", DefaultValue = "_name_")]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        [IntegerValidator(MinValue = 1, MaxValue = 100)]
        [ConfigurationProperty("Value", IsRequired = false, DefaultValue = 10)]
        public int Value
        {
            get { return (int)this["Value"]; }
            set { this["Value"] = value; }
        }

        [ConfigurationProperty("Time", DefaultValue = "00:00:00")]
        public TimeSpan Time
        {
            get { return (TimeSpan)this["Time"]; }
            set { this["Time"] = value; }
        }

        [ConfigurationProperty("Color", DefaultValue = Colors.Green)]
        public Colors Color
        {
            get { return (Colors)this["Color"]; }
            set { this["Color"] = value; }
        }

        #endregion
    }

    enum Colors
    {
        Red,
        Green,
        Blue,
    }
}
