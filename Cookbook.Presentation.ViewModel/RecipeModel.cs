using Cookbook.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Presentation.ViewModel
{
    sealed class RecipeModel
    {
        private readonly Recipe model;
        private RecipeModel recipe;

        public RecipeModel(RecipeModel recipe)
        {
            this.recipe = recipe;
        }

        public RecipeModel(Recipe model)
        {
            this.model = model;
        }
        public string Name => model.Name;
    }
}
