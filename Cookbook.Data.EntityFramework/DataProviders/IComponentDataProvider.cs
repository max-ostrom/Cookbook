using Cookbook.Data.EntityFramework.Gateways;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal interface IComponentDataProvider
    {
        Component FindComponentById(int componentId, RecipeDataGateway context);
        IEnumerable<Component> FindComponentsByRecipeId(int recipeId, RecipeDataGateway context);
    }
}
