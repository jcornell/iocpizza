namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;

    public interface INotificationEvent
    {
        Guid EventId { get; set; }

        string EventName { get; set; }

        IEnumerable<object> EventData { get; set; }
    }
}