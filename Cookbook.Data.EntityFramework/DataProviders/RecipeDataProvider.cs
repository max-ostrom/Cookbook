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
        public void AddRecipe(Recipe recipe, RecipeDataGateway context)
        {
            context.Recipes.Add(recipe);
            context.SaveChanges();
        }

        public IEnumerable<Recipe> FindAllRecipes(RecipeDataGateway context)
        {
            return context.Recipes.Include(n => n.Components);
        }

        public Recipe FindRecipeById(int recipeId, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes.Include(n => n.Components) where (n.Id == recipeId) select n;
            return names.ElementAt(0);
        }

        public Recipe FindRecipeByName(string recipeName, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes.Include(n => n.Components) where (n.Name == recipeName) select n;
            return names.ElementAt(0);
        }

        public bool tryDeleteRecipe(Recipe recipe, RecipeDataGateway context)
        {
            
            var lastSize = context.Recipes.Count();
            try
            {
                context.Recipes.Remove(recipe);
                context.SaveChanges();
            }
            catch
            {

            }
            return lastSize > context.Recipes.Count();
        }
    }
}
