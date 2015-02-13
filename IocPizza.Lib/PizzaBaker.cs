namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public class PizzaBaker : IBaker
    {
        private readonly IEnumerable<IRecipe> _recipes;
        private readonly IEnumerable<IUtensil> _utensils;
        private readonly INotificationHub _notificationHub;
        public CookStatus Status { get; set; }

        public PizzaBaker(IOven oven, IEnumerable<IRecipe> recipes, IEnumerable<IUtensil> utensils, INotificationHub notificationHub)
        {
            _recipes = recipes;
            _utensils = utensils;
            _notificationHub = notificationHub;
            Status = CookStatus.ReadyForOrder;
        }

        public void Bake(IEnumerable<IIngredient> ingredients, PizzaSize pizzaSize, Guid recipeId, Guid orderId)
        {
            var recipe = _recipes.Single(x => x.RecipeId == recipeId);
            var cookTime = recipe.RequiredTime;
            Thread.Sleep((int)cookTime.TotalSeconds); //Simulate some cooking time
            _notificationHub.Notify(
                new PizzaCompleteEvent
                    {
                        EventId = Guid.NewGuid(),
                        EventName = "PizzaReady",
                        EventData = new[] { new { RecipeId = recipeId, OrderId = orderId} }
                    });
        }
    }

    public interface INotificationHub
    {
        void Notify(INotificationEvent notificationEvent);
    }

    public class PizzaCompleteEvent : INotificationEvent
    {
        public Guid EventId { get; set; }

        public string EventName { get; set; }

        public IEnumerable<object> EventData { get; set; }
    }


    public class NotificationEvent : INotificationEvent
    {
        public Guid EventId { get; set; }

        public string EventName { get; set; }

        public IEnumerable<object> EventData { get; set; }
    }

    public interface INotificationEvent
    {
        Guid EventId { get; set; }

        string EventName { get; set; }

        IEnumerable<object> EventData { get; set; }
    }

    public interface IBaker
    {
        CookStatus Status { get; set; }

        void Bake(IEnumerable<IIngredient> ingredients, PizzaSize pizzaSize, Guid recipeId, Guid orderId);
    }

    public interface IIngredient
    {
        string Name { get; set; }

        int Quantity { get; set; }
    }

    public enum PizzaSize
    {
        Small = 0,

        Medium = 1,

        Large = 2
    }

    public enum OvenFuelType
    {
        Gas = 0,

        ElectricElement = 1,

        Wood = 2
    }

    public enum CookStatus
    {
        ReadyForOrder = 0,

        Preparing = 1,

        Cooking = 2,

        Complete = 3
    }

    public interface IUtensil
    {
        string Name { get; set; }
    }

    public interface IRecipe
    {
        Guid RecipeId { get; set; }

        IEnumerable<IIngredient> Ingredients { get; set; }

        string Directions { get; set; }

        TimeSpan RequiredTime { get; set; }
    }

    public interface IOven
    {
        OvenFuelType OvenFuelType { get; set; }

        int OvenCubicInches { get; set; }
    }

    public interface IMenu
    {
        IEnumerable<IMenuItem> MenuItems { get; set; }
    }

    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> MenuItems { get; set; }
    }

    public interface IMenuItem
    {
        string Title { get; set; }

        decimal Price { get; set; }

        Guid RecipeId { get; set; }
    }

    public class MenuItem : IMenuItem
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public Guid RecipeId { get; set; }
    }

    public class Utensil : IUtensil
    {
        public string Name { get; set; }
    }

    public class Recipe : IRecipe
    {
        public Guid RecipeId { get; set; }

        public IEnumerable<IIngredient> Ingredients { get; set; }

        public string Directions { get; set; }

        public TimeSpan RequiredTime { get; set; }
    }
}
