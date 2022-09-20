using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json.Serialization;

namespace CookBook.App.Models;

public class Recipe : BaseModel
{
    private string _name;

    [JsonPropertyName("name")]
    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    [JsonPropertyName("ingredients")] public ObservableCollection<Ingredient> Ingredients { get; set; }

    private string _description;

    [JsonPropertyName("description")]
    public string Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    private string _image;

    [JsonPropertyName("image")]
    public string Image
    {
        get => _image;
        set => SetField(ref _image, value);
    }

    [JsonIgnore]
    public string ImageS
    {
        get => $"{Directory.GetCurrentDirectory()}\\{_image}";
    }
}
