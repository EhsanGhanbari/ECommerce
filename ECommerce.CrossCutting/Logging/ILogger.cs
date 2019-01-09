using System;

namespace ECommerce.CrossCutting.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void Info(string message);
        void Error(string message);
        void Error(string message, Exception exception);
    }
}

