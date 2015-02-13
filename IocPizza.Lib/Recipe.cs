namespace IocPizza.Lib
{
    using System;
    using System.Collections.Generic;

    public class Recipe : IRecipe
    {
        public Guid RecipeId { get; set; }

        public IEnumerable<IIngredient> Ingredients { get; set; }

        public string Directions { get; set; }

        public TimeSpan RequiredTime { get; set; }
    }
}