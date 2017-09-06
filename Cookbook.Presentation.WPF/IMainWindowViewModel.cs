using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cookbook.Business.Models;
namespace Cookbook.Presentation.WPF
{
    public interface IMainWindowViewModel
    {
        IEnumerable<RecipeModel> Recipes { get; }
    }
}
