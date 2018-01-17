using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Business.Models;
using Cookbook.Data.EntityFramework.Gateways;

namespace Cookbook.Data.EntityFramework.DataProviders
{
    internal sealed class UnitDataProvider : IUnitDataProvider
    {
        public Unit FindUnitById(int unitId, RecipeDataGateway context)
        {
            IEnumerable<Unit> names = from n in context.Units where (n.Id == unitId) select n;
            return names.ElementAt(0);
        }
    }
}
