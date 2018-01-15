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
    internal sealed class IngredientDataProvider : IIngredientDataProvider
    {
        public Ingredient FindIngredientById(int ingredientId, RecipeDataGateway context)
        {
            throw new NotImplementedException();
        }
    }
}
