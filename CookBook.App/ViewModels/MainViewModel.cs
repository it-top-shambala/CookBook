using System.Collections.ObjectModel;
using CookBook.App.Models;

namespace CookBook.App.ViewModels;

public class MainViewModel : BaseViewModel
{
    public ObservableCollection<Recipe> Recipes { get; set; }

    private Recipe _recipe;
    public Recipe Recipe
    {
        get => _recipe;
        set => SetField(ref _recipe, value);
    }
}
