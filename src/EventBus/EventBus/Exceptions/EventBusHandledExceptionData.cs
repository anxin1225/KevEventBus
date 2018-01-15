using System;

namespace EventBus.Exceptions
{
    /// <summary>
    /// This type of events are used to notify for exceptions handled by eventbus infrastructure.
    /// </summary>
    public class EventBusHandledExceptionData : ExceptionData
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="exception">Exception object</param>
        public EventBusHandledExceptionData(Exception exception)
            : base(exception)
        {

        }
    }
}