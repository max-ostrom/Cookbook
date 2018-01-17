using Cookbook.Business.Models;
using System;
using System.Collections.Generic;

namespace Cookbook.Data.Gateways
{
    public interface IRecipeDataGateway : IDisposable
    {
        Recipe FindRecipe(string name);
        IEnumerable<Recipe> GetRecipes();

        bool tryDeleterecipe(string name);

        void addRecipe(Recipe recipe);
        void addComponent(Component component);
        void addIngredient(Ingredient ingredient);
    }
}