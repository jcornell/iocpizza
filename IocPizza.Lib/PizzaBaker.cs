using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocPizza.Lib
{
    public class PizzaBaker : IBaker
    {
        public PizzaBaker(IOven oven, IEnumerable<IRecipe> recipes, IEnumerable<IUtensils> utensils, INotificationHub notificationHub)
        {
            
        }

        public IStatus Status { get; set; }

        public TimeSpan Bake(IIngredients ingredients, ISize size, Guid recipeId)
        {
            throw new NotImplementedException();
        }
    }

    public interface INotificationHub
    {
        void Notify(INotificationEvent notificationEvent);
    }

    public interface INotificationEvent
    {
        Guid EventId { get; set; }
        string EventName { get; set; }
        IEnumerable<object> EventData { get; set; } 
    }

    public interface IBaker
    {
        IStatus Status { get; set; }
        TimeSpan Bake(IIngredients ingredients, ISize size, Guid recipeId);
    }

    public interface IIngredients
    {
    }

    public interface ISize
    {
    }

    public interface IStatus
    {
    }

    public interface IUtensils
    {
    }

    public interface IRecipe
    {
    }

    public interface IOven
    {
    }

    public interface IMenu
    {
        
    }
}
