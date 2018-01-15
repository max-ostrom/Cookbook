using Cookbook.Data.EntityFramework.DataProviders;
using Cookbook.Data.EntityFramework.Gateways;
using Cookbook.Data.Gateways;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Data.EntityFramework
{
    public sealed class EntityFrameworkNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRecipeDataService>().To<RecipeDataService>().InSingletonScope();
            Bind<IRecipeDataGateway>().To<RecipeDataGateway>().InSingletonScope();

            Bind<IComponentDataProvider>().To<ComponentDataProvider>().InSingletonScope();
            Bind<IIngredientDataProvider>().To<IngredientDataProvider>().InSingletonScope();
            Bind<IRecipeDataProvider>().To<RecipeDataProvider>().InSingletonScope();
            Bind<IUnitDataProvider>().To<UnitDataProvider>().InSingletonScope();
        }
    }
}
