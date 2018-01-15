using Cookbook.Data.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework
{
    internal sealed class RecipeDataService : IRecipeDataService
    {

        private readonly IRecipeDataGateway dataGateway;

        public RecipeDataService(IRecipeDataGateway dataGateway)
        {
            this.dataGateway = dataGateway;
        }

        public IRecipeDataGateway OpenDataGateway()
        {
            return dataGateway;
        }

    }
}
