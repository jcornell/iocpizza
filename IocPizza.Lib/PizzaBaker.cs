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
}
