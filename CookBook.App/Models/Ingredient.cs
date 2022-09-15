using System.Text.Json.Serialization;

namespace CookBook.App.Models;

public class Ingredient : BaseModel
{
    private string _name;

    [JsonPropertyName("name")]
    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    private string _measure;

    [JsonPropertyName("measure")]
    public string Measure
    {
        get => _measure;
        set => SetField(ref _measure, value);
    }

    private double _amount;

    [JsonPropertyName("amount")]
    public double Amount
    {
        get => _amount;
        set => SetField(ref _amount, value);
    }
}
