using System;
using ECommerce.CrossCutting.Configuration;
using log4net;
using log4net.Config;

namespace ECommerce.CrossCutting.Logging
{
    public class Log4NetAdapter : ILogger
    {
        private readonly ILog _log;

        public Log4NetAdapter()
        {
            _log = LogManager.GetLogger(this.GetType());
            XmlConfigurator.Configure();
            // _log = LogManager.GetLogger(ApplicationSettingsFactory.GetApplicationSettings().LoggerName);
        }

        public void Log(string message)
        {
            _log.Info(message);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _log.Error(message, exception);
        }
    }
}
