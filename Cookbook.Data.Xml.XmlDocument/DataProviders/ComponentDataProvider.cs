using Cookbook.Business.Models;
using ComponentDto = Cookbook.Data.Xml.XmlDocument.TransferObjects.Component;
using ComponentElement = Cookbook.Data.Xml.XmlDocument.DataProviders.Elements.Component;

namespace Cookbook.Data.Xml.XmlDocument.DataProviders
{
    using System.Xml;

    internal sealed class ComponentDataProvider : IComponentDataProvider
    {
        private readonly IIngredientDataProvider ingredientDataProvider;
        private readonly IUnitDataProvider unitDataProvider;

        public ComponentDataProvider(IIngredientDataProvider ingredientDataProvider, IUnitDataProvider unitDataProvider)
        {
            this.ingredientDataProvider = ingredientDataProvider;
            this.unitDataProvider = unitDataProvider;
        }

        public Component ReadComponentFromNode(XmlNode componentNode, XmlDocument document)
        {
            var _Id = int.Parse(componentNode.Attributes[ComponentElement.Id].Value.ToString());
            var _IngredientId = int.Parse(componentNode.Attributes[ComponentElement.IngredientId].Value.ToString());
            var _Quantity = double.Parse(componentNode.Attributes[ComponentElement.Quantity].Value.ToString());
            var _UnitId = int.Parse(componentNode.Attributes[ComponentElement.UnitId].Value.ToString());
            var componentDto = new ComponentDto
            {   Id = _Id,
                IngredientId = _IngredientId,
                Quantity = _Quantity,
                UnitId = _UnitId
            };

            Ingredient ingredient = ingredientDataProvider.FindIngredientById(componentDto.IngredientId, document);
            Unit unit = unitDataProvider.FindUnitById(componentDto.UnitId, document);

            return new Component(
                id: componentDto.Id,
                ingredient: ingredient,
                quantity: componentDto.Quantity,
                unit: unit
            );
        }
    }
}