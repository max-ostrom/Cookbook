using Cookbook.Business.Models;
using System.Collections.Generic;

namespace Cookbook.Business
{
    public interface IRecipeManager
    {
        Recipe FindRecipe(string name);
        IEnumerable<Recipe> GetRecipes();
        bool tryDeleteRecipe(string name);
        bool tryAddRecipe(string name, IEnumerable<Component> components);
        bool tryAddRecipe(Recipe newRecipe);
        bool tryAddUnit(string singularName, string pluralName);
        bool tryAddUnit(Unit newUnit);
        bool tryAddIngredient(string name);
        bool tryAddIngredient(Ingredient newIngredient);
        bool tryAddComponent(Ingredient ingredient, double quantity, Unit unit);
        bool tryAddComponent(Component newComponent);
    }
}