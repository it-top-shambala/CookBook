using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CookBook.App.Models;

public static class Recipes
{
    public static IEnumerable<Recipe> ImportFromJson()
    {
        var json = File.ReadAllText("./Assets/recipes.json");
        return JsonSerializer.Deserialize<IEnumerable<Recipe>>(json);
    }
}
