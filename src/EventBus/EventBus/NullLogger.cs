using Castle.Core.Logging;

namespace EventBus
{
    internal class NullLogger
    {
        public static ILogger Instance { get; internal set; }
    }
}