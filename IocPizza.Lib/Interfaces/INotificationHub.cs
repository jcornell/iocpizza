namespace IocPizza.Lib
{
    public interface INotificationHub
    {
        void Notify(INotificationEvent notificationEvent);
    }
}