using Ninject.Infrastructure.Disposal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using Cookbook.Data.Gateways;

namespace Cookbook.Data.EntityFramework.Gateways
{
    internal sealed class RecipeDataGateway : DbContext, IRecipeDataGateway
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Component> Components { get; set; }

        public Recipe FindRecipe(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            throw new NotImplementedException();
        }

        public bool tryDeleterecipe(string name)
        {
            throw new NotImplementedException();
        }
    }
}
