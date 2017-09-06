using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Presentation.ViewModel
{
    internal interface IMainWindowViewModel
    {
        IEnumerable<RecipeModel> Recipes { get; }
    }
}
