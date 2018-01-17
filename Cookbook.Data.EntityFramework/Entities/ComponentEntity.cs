using Cookbook.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework.Entities
{
    public sealed class ComponentEntity
    {
        private readonly int id;
        private readonly IngredientEntity ingredient;
        private readonly double quantity;
        private readonly UnitEntity unit;

        public ComponentEntity(int id, IngredientEntity ingredient, double quantity, UnitEntity unit)
        {
            this.id = id;
            this.ingredient = ingredient;
            this.quantity = quantity;
            this.unit = unit;
        }

        public int Id => id;

        public IngredientEntity Ingredient => ingredient;

        public double Quantity => quantity;

        public UnitEntity Unit => unit;
        public Component ToComponent()
        {
            return new Component(id, ingredient.ToIngredient(), quantity, unit.ToUnit());
        }
    }
}
