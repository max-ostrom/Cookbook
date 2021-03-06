﻿using Cookbook.Business.Models;
using Cookbook.Data.EntityFramework.Gateways;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal interface IRecipeDataProvider
    {
        IEnumerable<Recipe> FindAllRecipes(RecipeDataGateway context);
        Recipe FindRecipeById(int recipeId, RecipeDataGateway context);
        Recipe FindRecipeByName(string recipeName, RecipeDataGateway context);

        void AddRecipe(Recipe recipe, RecipeDataGateway context);
        bool tryDeleteRecipe(Recipe recipe, RecipeDataGateway context);
    }
}
