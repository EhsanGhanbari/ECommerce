namespace ECommerce.CrossCutting.Configuration
{
    
    public class ApplicationSettingsFactory
    {
        private static IApplicationSetting _applicationSetting;

        public static void InitializeApplicationSettingFactory(IApplicationSetting applicationSetting )
        {
            _applicationSetting = applicationSetting;
        }
        public static IApplicationSetting GetApplicationSettings()
        {
            return _applicationSetting;
        }
    }
}
