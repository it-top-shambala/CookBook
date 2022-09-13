using System;
using System.Collections.ObjectModel;

namespace CookBook.App.Models;

public class Recipe : BaseModel
{
    private string _name;

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    public ObservableCollection<Ingredient> Ingredients { get; set; }

    private string _description;

    public string Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    private Uri _image;

    public Uri Image
    {
        get => _image;
        set => SetField(ref _image, value);
    }
}
