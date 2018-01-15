using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EventBus.Exceptions
{
    /// <summary>
    /// Base exception type for those are thrown by eventbus system for eventbus specific exceptions.
    /// </summary>
    [Serializable]
    public class EventBusException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="EventBusException"/> object.
        /// </summary>
        public EventBusException()
        {

        }

        /// <summary>
        /// Creates a new <see cref="EventBusException"/> object.
        /// </summary>
        public EventBusException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        /// <summary>
        /// Creates a new <see cref="EventBusException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public EventBusException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="EventBusException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public EventBusException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
