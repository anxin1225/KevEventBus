using System;

namespace EventBus.Interface
{
    public interface ILogger
    {
        void Info(string message);

        void Debug(string message);

        void Warn(string message, Exception ex);

        void Error(string message, Exception ex = null);
    }
}