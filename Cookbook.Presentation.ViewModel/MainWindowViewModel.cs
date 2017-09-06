using Cookbook.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Presentation.ViewModel
{
    class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly ICollection<RecipeModel> recipes;
        MainWindowViewModel(IRecipeManager recipeManager)
        {
            recipes = new List<RecipeModel>();
            foreach (RecipeModel recipe in recipes)
            {
                recipes.Add(new RecipeModel(recipe));
            }
        }
        public IEnumerable<RecipeModel> Recipes => recipes;
    }
}
