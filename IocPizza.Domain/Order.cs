using System;

namespace IocPizza.Domain
{
    public class Order : IOrder
    {
        public Guid OrderId { get; set; }

        public DateTime OrderCreatedOn { get; set; }

        public DateTime OrderCompletedOn { get; set; }

        public string OrderInfo { get; set; }
    }

    public interface IOrder
    {
        Guid OrderId { get; set; }
        DateTime OrderCreatedOn { get; set; }
        DateTime OrderCompletedOn { get; set; }
        string OrderInfo { get; set; }
    }
}
