namespace IocPizza.Lib
{
    using System;

    public class MenuItem : IMenuItem
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public Guid RecipeId { get; set; }
    }
}