using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;

namespace Cookbook.Data.EntityFramework.Entities
{
    public sealed class IngredientEntity
    {
        private readonly int id;
        private readonly string name;

        public IngredientEntity(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id => id;

        public string Name => name;

        public Ingredient ToIngredient()
        {
            return new Ingredient(id, name);
        }
    }
}
