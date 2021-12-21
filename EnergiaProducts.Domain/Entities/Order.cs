using EnergiaProducts.Domain.Models;

namespace EnergiaProducts.Domain.Entities
{
    public class Order
    {
        private Order()
        {
        }
        public Guid Id { get; private set; }

        public decimal PaidAmount { get; private set; }

        public decimal TotalAmount { get; private set; }

        public DateTime CreatedOn { get; private set; }

        public string CasheirName { get; private set; }

        public ICollection<OrderItem> Items { get; private set; }


        public static Order Place(PlaceOrderRequest placeOrderRequest, IEnumerable<Product> products)
        {
            var totalAmount = placeOrderRequest.OrderedProducts.Sum(product => product.Quantity * product.PricePerUnit);
            if (placeOrderRequest.PaidAmount < totalAmount)
                throw new Exception("Paid Amount was less than Order's total");

            var orderedProductQuantities = placeOrderRequest.OrderedProducts.ToDictionary(product => product.ProductId, product => product.Quantity);
            foreach (var product in products)
            {
                var orderedQunatity = orderedProductQuantities[product.Id];
                product.Order(orderedQunatity);
            }

            var order = new Order
            {
                Id = Guid.NewGuid(),
                CasheirName = placeOrderRequest.CashierName,
                CreatedOn = DateTime.Now,
                TotalAmount = totalAmount,
                PaidAmount = placeOrderRequest.PaidAmount,
            };
            return order;
        }
    }
}
