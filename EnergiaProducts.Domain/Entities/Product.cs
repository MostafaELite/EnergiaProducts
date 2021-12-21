using System;

namespace EnergiaProducts.Domain.Entities
{
    public class Product
    {
        //In the interview
        public Product(){}
        public Product(string name, UnitType unitType, decimal pricePerUnit, Guid categoryId,  decimal? availableQuantity = null)
        {
            Id = Guid.NewGuid();
            Name = name;
            UnitType = unitType;
            PricePerUnit = pricePerUnit;
            AvailableQuantity = availableQuantity;
            CategoryId = categoryId;
        }

        public Guid Id { get; }

        public string Name { get; }

        public decimal? AvailableQuantity { get; private set; }

        public decimal PricePerUnit { get; }

        public UnitType UnitType { get; }

        public Guid CategoryId { get; set; }

        public ProductCategory Category { get; set; }

        public bool CanBeOrdered(decimal orderedQuantity) => AvailableQuantity >= orderedQuantity;

        internal void Order(decimal orderedQunatity)
        {
            if (!CanBeOrdered(orderedQunatity))
                throw new Exception("Ordered quanitity exceeded the available quantity");

            AvailableQuantity -= orderedQunatity;
        }
    }
}