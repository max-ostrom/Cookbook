using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using Cookbook.Data.EntityFramework.Gateways;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal sealed class RecipeDataProvider : IRecipeDataProvider
    {
        public IEnumerable<Recipe> FindAllRecipes(RecipeDataGateway context)
        {
            return context.Recipes;
        }

        public Recipe FindRecipeById(int recipeId, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes where (n.Id == recipeId) select n;
            return names.ElementAt(0);
        }

        public Recipe FindRecipeByName(string recipeName, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes where (n.Name == recipeName) select n;
            return names.ElementAt(0);
        }
    }
}
