using System;

namespace EventBus
{
    public interface ILogger
    {
        void Warn(string v, Exception ex);
    }
}