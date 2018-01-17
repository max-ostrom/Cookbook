using Ninject.Infrastructure.Disposal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using Cookbook.Data.Gateways;
using Cookbook.Data.EntityFramework.DataProviders;

namespace Cookbook.Data.EntityFramework.Gateways
{
    internal sealed class RecipeDataGateway : DbContext, IRecipeDataGateway
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Component> Components { get; set; }

        private readonly IRecipeDataProvider recipeDataProvider;
        private readonly IComponentDataProvider componentDataProvider;
        private readonly IUnitDataProvider unitDataProvider;
        private readonly IIngredientDataProvider ingredientDataProvider;
        public RecipeDataGateway(IRecipeDataProvider recipeDataProvider, IComponentDataProvider componentDataProvider, IUnitDataProvider unitDataProvider, IIngredientDataProvider ingredientDataProvider)
        {
            this.recipeDataProvider = recipeDataProvider;
            this.componentDataProvider = componentDataProvider;
            this.unitDataProvider = unitDataProvider;
            this.ingredientDataProvider = ingredientDataProvider;
        }

        public Recipe FindRecipe(string name)
        {
            return recipeDataProvider.FindRecipeByName(name, this);
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipeDataProvider.FindAllRecipes(this);
        }

        public bool tryDeleterecipe(string name)
        {
            throw new NotImplementedException();
        }

        public void addRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void addComponent(Component component)
        {
            throw new NotImplementedException();
        }

        public void addIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
