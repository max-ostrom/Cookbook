using Cookbook.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Presentation.WPF.ViewModel.Models
{
    public sealed class RecipeDescriptionModel
    {
        private readonly Recipe model;

        public RecipeDescriptionModel(Recipe model)
        {
            this.model = model;
        }
        private string CreateDescription()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Recipe : " + model.Name);
            foreach (var item in model.Components)
            {
                stringBuilder.AppendLine("\t" + item.Ingredient.Name + " " + item.Quantity + " " + item.Unit.PluralName);
            }
            return stringBuilder.ToString();
        }
        public string Name => CreateDescription();
    }
}
