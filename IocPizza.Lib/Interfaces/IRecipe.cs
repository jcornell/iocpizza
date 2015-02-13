namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;

    public interface IRecipe
    {
        Guid RecipeId { get; set; }

        IEnumerable<IIngredient> Ingredients { get; set; }

        string Directions { get; set; }

        TimeSpan RequiredTime { get; set; }
    }
}