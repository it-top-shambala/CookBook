using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace CookBook.App.Models;

public static class Recipes
{
    private const string Path = "./Assets/recipes.json";

    public static IEnumerable<Recipe> ImportFromJson()
    {
        var json = File.ReadAllText(Path);
        return JsonSerializer.Deserialize<IEnumerable<Recipe>>(json);
    }

    public static void ExportToJson(IEnumerable<Recipe> recipes)
    {
        var json = JsonSerializer.Serialize(recipes, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        });
        File.WriteAllText(Path, json);
    }
}
