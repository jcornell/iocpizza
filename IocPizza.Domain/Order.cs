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
}
