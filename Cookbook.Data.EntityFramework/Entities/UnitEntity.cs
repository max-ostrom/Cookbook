using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;

namespace Cookbook.Data.EntityFramework.Entities
{
    public sealed class UnitEntity
    {
        private readonly int id;
        private readonly string pluralName;
        private readonly string singularName;

        public UnitEntity(int id, string singularName, string pluralName)
        {
            this.id = id;
            this.pluralName = pluralName;
            this.singularName = singularName;
        }

        public int Id => id;

        public string PluralName => pluralName;

        public string SingularName => singularName;
        public Unit ToUnit()
        {
            return new Unit(id, singularName, pluralName);
        }
    }
}
