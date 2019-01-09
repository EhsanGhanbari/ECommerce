using System;

namespace ECommerce.CrossCutting.Configuration
{
    public class ApplicationConfiguration
    {
        private ApplicationConfiguration()
        { }

        static Lazy<ApplicationConfiguration> _lazy = new Lazy<ApplicationConfiguration>(() =>
        {
            return new ApplicationConfiguration()
            {
                Value = ApplicationConfigurationSection.Current.Value,
                Entity = new Entity()
                {
                    Name = ApplicationConfigurationSection.Current.Entity.Name,
                    Value = ApplicationConfigurationSection.Current.Entity.Value,
                }
            };
        });

        public static ApplicationConfiguration Current
        {
            get { return _lazy.Value; }
        }

        public int Value { get; private set; }
        public Entity Entity { get; private set; }

    }

    public class Entity
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
