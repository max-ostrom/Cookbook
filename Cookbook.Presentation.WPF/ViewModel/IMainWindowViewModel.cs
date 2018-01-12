using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cookbook.Business.Models;
using Cookbook.Presentation.WPF.ViewModel.Models;

namespace Cookbook.Presentation.WPF
{
    public interface IMainWindowViewModel
    {
        IEnumerable<RecipeModel> Recipes { get; }
        RecipeDescriptionModel CurrentRecipe { get; set; }
        void setCurrentRecipe(RecipeModel recipeModel);
        void setCurrentRecipe(object recipeModel);
    }
}
