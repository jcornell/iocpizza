namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;

    public class NotificationEvent : INotificationEvent
    {
        public Guid EventId { get; set; }

        public string EventName { get; set; }

        public IEnumerable<object> EventData { get; set; }
    }
}