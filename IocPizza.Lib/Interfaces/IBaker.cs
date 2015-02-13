namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;

    public interface IBaker
    {
        CookStatus Status { get; set; }

        void Bake(IEnumerable<IIngredient> ingredients, PizzaSize pizzaSize, Guid recipeId, Guid orderId);
    }
}