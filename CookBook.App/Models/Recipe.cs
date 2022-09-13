using System;
using System.Collections.Generic;

namespace CookBook.App.Models;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Description { get; set; }
    public Uri Image { get; set; }
}
