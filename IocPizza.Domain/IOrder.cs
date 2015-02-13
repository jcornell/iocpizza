namespace IocPizza.Domain
{
    using System;

    public interface IOrder
    {
        Guid OrderId { get; set; }
        DateTime OrderCreatedOn { get; set; }
        DateTime OrderCompletedOn { get; set; }
        string OrderInfo { get; set; }
    }
}