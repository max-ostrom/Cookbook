using Cookbook.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using System.Collections.ObjectModel;
using Cookbook.Presentation.WPF.ViewModel.Models;
using System.ComponentModel;

namespace Cookbook.Presentation.WPF
{
    public class MainWindowViewModel : IMainWindowViewModel, INotifyPropertyChanged
    {
        private readonly ICollection<RecipeModel> recipes;
        private RecipeDescriptionModel currentRecipe;
        private readonly IRecipeManager recipeManager;
        public MainWindowViewModel(IRecipeManager recipeManager)
        {
            this.recipeManager = recipeManager;
            recipes = new ObservableCollection<RecipeModel>();
            foreach (var recipe in recipeManager.GetRecipes())
            {
                recipes.Add(new RecipeModel(recipe));
            }
        }
        public IEnumerable<RecipeModel> Recipes => recipes;
        public void setCurrentRecipe(RecipeModel recipeModel)
        {
            var recipe  = recipeManager.FindRecipe(recipeModel.Name);
            currentRecipe = new RecipeDescriptionModel(recipe);
            RaisePropertyChanged("CurrentRecipe");
        }
        public void setCurrentRecipe(object recipeModel)
        {
            var recipe = recipeManager.FindRecipe((recipeModel as RecipeModel).Name);
            currentRecipe = new RecipeDescriptionModel(recipe);
            RaisePropertyChanged("CurrentRecipe");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public RecipeDescriptionModel CurrentRecipe { get => currentRecipe; set => setCurrentRecipe(value); }
    }
}
