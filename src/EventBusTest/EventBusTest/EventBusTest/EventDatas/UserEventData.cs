using EventBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusTest.EventDatas
{
    public class UserEventData : EventData
    {
        public User User { get; set; }
    }

    public class CreateUserEventData : UserEventData
    {
        public DateTime CreateTime { get; set; }
    }
}
