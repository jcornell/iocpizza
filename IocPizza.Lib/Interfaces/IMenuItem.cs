namespace IocPizza.Lib
{
    using System;

    public interface IMenuItem
    {
        string Title { get; set; }

        decimal Price { get; set; }

        Guid RecipeId { get; set; }
    }
}