using EventBus.Handlers;
using EventBusTest.EventDatas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventBusTest.Handlers
{
    public class UserHandler : IEventHandler<UserEventData>, IEventHandler<CreateUserEventData>
    {
        public void HandleEvent(UserEventData eventData)
        {
            eventData.User.Id++;
            Console.WriteLine($"Handle {nameof(UserEventData)} {eventData.User.Id} {Thread.CurrentThread.ManagedThreadId}");
        }

        public void HandleEvent(CreateUserEventData eventData)
        {
            Console.WriteLine($"Handle {nameof(CreateUserEventData)} {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
