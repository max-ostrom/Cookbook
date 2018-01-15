using Cookbook.Data.EntityFramework.DataProviders;
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
            //Bind<IRecipeDataService>().To<RecipeDataService>().InSingletonScope();

            Bind<IComponentDataProvider>().To<ComponentDataProvider>().InSingletonScope();
            Bind<IIngredientDataProvider>().To<IngredientDataProvider>().InSingletonScope();
            Bind<IRecipeDataProvider>().To<RecipeDataProvider>().InSingletonScope();
            Bind<IUnitDataProvider>().To<UnitDataProvider>().InSingletonScope();
        }
    }
}
