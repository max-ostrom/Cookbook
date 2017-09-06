using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;


namespace Cookbook.Presentation.WPF
{
    internal sealed class WPFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<MainWindow>().ToSelf();
            Bind<IMainWindowViewModel>().To<MainWindowViewModel>().InSingletonScope();
        }
    }
}
