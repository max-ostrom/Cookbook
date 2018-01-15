using Cookbook.Business.Models;
using Cookbook.Data.EntityFramework.Gateways;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal interface IIngredientDataProvider
    {
        Ingredient FindIngredientById(int ingredientId, RecipeDataGateway context);
    }
}
