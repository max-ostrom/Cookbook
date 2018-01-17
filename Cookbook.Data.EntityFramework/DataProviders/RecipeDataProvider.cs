using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using Cookbook.Data.EntityFramework.Gateways;
using Cookbook.Data.EntityFramework.Entities;
using System.Collections.ObjectModel;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal sealed class RecipeDataProvider : IRecipeDataProvider
    {
        public void AddRecipe(Recipe recipe, RecipeDataGateway context)
        {
            ObservableCollection<ComponentEntity> newComponents = new ObservableCollection<ComponentEntity>();
            foreach (var item in recipe.Components)
            {
                newComponents.Add(
                    new ComponentEntity(item.Id, 
                    new IngredientEntity(item.Ingredient.Id, item.Ingredient.Name),
                    item.Quantity,
                    new UnitEntity(item.Unit.Id, item.Unit.SingularName, item.Unit.PluralName)
                    ));
            }
            context.Recipes.Add(new RecipeEntity(recipe.Id, recipe.Name, newComponents));
            context.SaveChanges();
        }

        public IEnumerable<Recipe> FindAllRecipes(RecipeDataGateway context)
        {
            ObservableCollection<Recipe> newRecipe = new ObservableCollection<Recipe>();
            foreach (var item in context.Recipes.Include(n => n.Components))
            {
                newRecipe.Add(item.ToRecipe());
            }
            return newRecipe;
        }

        public Recipe FindRecipeById(int recipeId, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes.Include(n => n.Components) where (n.Id == recipeId) select n.ToRecipe();
            return names.ElementAt(0);
        }

        public Recipe FindRecipeByName(string recipeName, RecipeDataGateway context)
        {
            IEnumerable<Recipe> names = from n in context.Recipes.Include(n => n.Components) where (n.Name == recipeName) select n.ToRecipe();
            return names.ElementAt(0);
        }

        public bool tryDeleteRecipe(Recipe recipe, RecipeDataGateway context)
        {
            
            var lastSize = context.Recipes.Count();
            try
            {
                //context.Recipes.Remove(recipe);
                context.SaveChanges();
            }
            catch
            {

            }
            return lastSize > context.Recipes.Count();
        }
    }
}
