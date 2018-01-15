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
            throw new NotImplementedException();
        }

        public Recipe FindRecipeById(int recipeId, RecipeDataGateway context)
        {
            throw new NotImplementedException();
        }

        public Recipe FindRecipeByName(string recipeName, RecipeDataGateway context)
        {
            throw new NotImplementedException();
        }
    }
}
