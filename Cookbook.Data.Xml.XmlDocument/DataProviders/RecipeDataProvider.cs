﻿using Cookbook.Business.Models;
using Cookbook.Data.Xml.XmlDocument.Exceptions;
using System.Collections.Generic;
using RecipeDto = Cookbook.Data.Xml.XmlDocument.TransferObjects.Recipe;
using RecipeElement = Cookbook.Data.Xml.XmlDocument.DataProviders.Elements.Recipe;

namespace Cookbook.Data.Xml.XmlDocument.DataProviders
{
    using System.Xml;

    internal sealed class RecipeDataProvider : IRecipeDataProvider
    {
        private readonly IComponentDataProvider componentDataProvider;

        public RecipeDataProvider(IComponentDataProvider componentDataProvider)
        {
            this.componentDataProvider = componentDataProvider;
        }

        public IEnumerable<Recipe> FindAllRecipes(XmlDocument document)
        {
            var recipes = new List<Recipe>();

            foreach (XmlNode recipeNode in document.GetElementsByTagName(RecipeElement.TagName))
            {
                Recipe recipe = ReadRecipeFromNode(recipeNode, document);
                recipes.Add(recipe);
            }

            return recipes;
        }

        public Recipe FindRecipeByName(string recipeName, XmlDocument document)
        {
            foreach (XmlNode recipeNode in document.GetElementsByTagName(RecipeElement.TagName))
            {
                if (recipeNode.Attributes[RecipeElement.Name].Value.Equals(recipeName))
                {
                    return ReadRecipeFromNode(recipeNode, document);
                }
            }

            throw new RecipeNameNotFoundXmlDataException(recipeName);
        }

        public Recipe ReadRecipeFromNode(XmlNode recipeNode, XmlDocument document)
        {
            var recipeDto = new RecipeDto
            {
                Id = int.Parse(recipeNode.Attributes[RecipeElement.Id].Value),
                Name = recipeNode.Attributes[RecipeElement.Name].Value
            };

            var components = new List<Component>();

            foreach (XmlNode componentNode in recipeNode.FirstChild.ChildNodes)
            {
                Component component = componentDataProvider.ReadComponentFromNode(componentNode, document);
                components.Add(component);
            }

            return new Recipe(
                id: recipeDto.Id,
                name: recipeDto.Name,
                components: components
            );
        }
    }
}