using Cookbook.Business.Exceptions;
using Cookbook.Business.Models;
using Cookbook.Data;
using Cookbook.Data.Exceptions;
using Cookbook.Data.Gateways;
using System;
using System.Collections.Generic;

namespace Cookbook.Business
{
    internal sealed class RecipeManager : IRecipeManager
    {
        private readonly IRecipeDataService dataService;

        public RecipeManager(IRecipeDataService dataService)
        {
            this.dataService = dataService;
        }

        public Recipe FindRecipe(string name)
        {
            try
            {
                using (IRecipeDataGateway dataGateway = dataService.OpenDataGateway())
                {
                    return dataGateway.FindRecipe(name);
                }
            }
            catch (RecipeNotFoundDataException exception)
            {
                throw new RecipeNotFoundBusinessException(name, exception);
            }
            catch (Exception exception)
            {
                throw new DataSourceBusinessException(exception);
            }
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            try
            {
                using (IRecipeDataGateway dataGateway = dataService.OpenDataGateway())
                {
                    return dataGateway.GetRecipes();
                }
            }
            catch (Exception exception)
            {
                throw new DataSourceBusinessException(exception);
            }
        }




        public bool tryAddComponent(Ingredient ingredient, double quantity, Unit unit)
        {
            throw new NotImplementedException();
        }

        public bool tryAddComponent(Component newComponent)
        {
            throw new NotImplementedException();
        }




        public bool tryAddIngredient(string name)
        {
            throw new NotImplementedException();
        }

        public bool tryAddIngredient(Ingredient newIngredient)
        {
            throw new NotImplementedException();
        }




        public bool tryAddRecipe(string name, IEnumerable<Component> components)
        {
            throw new NotImplementedException();
        }

        public bool tryAddRecipe(Recipe newRecipe)
        {
            throw new NotImplementedException();
        }




        public bool tryAddUnit(string singularName, string pluralName)
        {
            throw new NotImplementedException();
        }

        public bool tryAddUnit(Unit newUnit)
        {
            throw new NotImplementedException();
        }

        public bool tryDeleteRecipe(string name)
        {
            throw new NotImplementedException();
        }
    }
}