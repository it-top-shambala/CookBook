using System.Collections.ObjectModel;
using System.Windows.Input;
using CookBook.App.Commands;
using CookBook.App.Models;

namespace CookBook.App.ViewModels;

public class MainViewModel : BaseViewModel
{
    public ObservableCollection<Recipe> Recipes { get; }

    private Recipe _recipe;

    public Recipe Recipe
    {
        get => _recipe;
        set => SetField(ref _recipe, value);
    }

    public ICommand ShowRecipeCommand { get; set; }

    public MainViewModel()
    {
        ShowRecipeCommand = new LambdaCommand(_ =>
        {
            Models.Recipes.ExportToJson(Recipes);
        }, _ => true);

        Recipes = new ObservableCollection<Recipe>(Models.Recipes.ImportFromJson());
    }
}
