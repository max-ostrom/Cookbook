using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using System.Collections.ObjectModel;

namespace Cookbook.Data.EntityFramework.Entities
{
    public sealed class RecipeEntity
    {
        private readonly ICollection<ComponentEntity> components;
        private readonly int id;
        private readonly string name;

        public RecipeEntity(int id, string name, ICollection<ComponentEntity> components)
        {
            this.components = components;
            this.id = id;
            this.name = name;
        }

        public ICollection<ComponentEntity> Components => components;

        public int Id => id;

        public string Name => name;

        public Recipe ToRecipe()
        {
            ObservableCollection<Component> newComponents = new ObservableCollection<Component>();
            foreach (var item in components)
            {
                newComponents.Add(item.ToComponent());
            }
            return new Recipe(id,name,newComponents);
        }
    }
}
