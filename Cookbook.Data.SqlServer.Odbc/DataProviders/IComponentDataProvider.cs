﻿using Cookbook.Business.Models;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Cookbook.Data.SqlServer.Odbc.DataProviders
{
    internal interface IComponentDataProvider
    {
        Component FindComponentById(int componentId, OdbcConnection connection);
        IEnumerable<Component> FindComponentsByRecipeId(int recipeId, OdbcConnection connection);
    }
}