namespace ECommerce.CrossCutting.Configuration
{
    /// <summary>
    /// this is for logging mechanism
    /// </summary>
    public interface IApplicationSetting
    {
        string LoggerName { get; }
    }
}
