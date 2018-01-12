using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using Cookbook.Business;
using Cookbook.Data.SqlServer;
using Cookbook.Data.SqlServer.Odbc;

using Ninject;
using Cookbook.Data.Mocks;
using Cookbook.Data.Xml.XmlDocument;

namespace Cookbook.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Lazy<IKernel> kernel;
        public App()
        {
            kernel = new Lazy<IKernel>(CreateKernel);
            Startup += App_Startup;
        }
        private void App_Startup(object sender, StartupEventArgs e)
        {
            kernel.Value.Get<MainWindow>().Show();
        }
        private IKernel CreateKernel()
        {
            var kernel = new StandardKernel
            (
               new BusinessNinjectModule(),
               new MockDataNinjectModule(),
               new WPFNinjectModule()
            );
            return kernel;
        }
    }
}
