using EventBus;
using System;
using Autofac;
using EventBusTest.EventDatas;
using EventBusTest.Handlers;
using System.Threading;

namespace EventBusTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<EventBus.EventBus>().As<IEventBus>();
            var container = builder.Build();

            var eventbus = container.Resolve<IEventBus>();

            UserHandler handler = new UserHandler();
            eventbus.Register<UserEventData>(handler);
            eventbus.Register<CreateUserEventData>(handler);

            Console.WriteLine($"Thread.Id {Thread.CurrentThread.ManagedThreadId}");

            //new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        eventbus.Trigger<UserEventData>(new UserEventData { User = new User { Name = "bianchx", DisplayName = "bianchx", Password = "123456" } });
            //        eventbus.Trigger<CreateUserEventData>(new CreateUserEventData { User = new User { Name = "bianchx", DisplayName = "bianchx", Password = "123456" }, CreateTime = DateTime.Now });

            //        Thread.Sleep(500);

            //        Console.WriteLine($"New1 Thread.Id {Thread.CurrentThread.ManagedThreadId}");
            //    }
            //}).Start();

            new Thread(() =>
            {
                var edata = new UserEventData { User = new User { Name = "bianchx", DisplayName = "bianchx", Password = "123456" } };

                for (int i = 0; i < 10; i++)
                {
                    eventbus.Trigger<UserEventData>(edata);

                    Console.WriteLine($"New2 Thread.Id {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(500);
                }
            }).Start();

            //for (int i = 0; i < 10; i++)
            //{
            //    eventbus.Trigger<UserEventData>(new UserEventData { User = new User { Name = "bianchx", DisplayName = "bianchx", Password = "123456" } });
            //    eventbus.Trigger<CreateUserEventData>(new CreateUserEventData { User = new User { Name = "bianchx", DisplayName = "bianchx", Password = "123456" }, CreateTime = DateTime.Now });

            //    Console.WriteLine($"Main Thread.Id {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(500);
            //}

            Console.ReadLine();

        }
    }
}
