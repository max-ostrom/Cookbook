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
    internal sealed class ComponentDataProvider : IComponentDataProvider
    {
        public Component FindComponentById(int componentId, RecipeDataGateway context)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Component> FindComponentsByRecipeId(int recipeId, RecipeDataGateway context)
        {
            throw new NotImplementedException();/*
            IEnumerable<Component> names = from n in context.Recipes where (n.Id == recipeId) select n.Components;
            return names;*/
        }
    }
}
