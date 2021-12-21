namespace EnergiaProducts.Models.Requests
{
    public class OrderedItem
    {
        public Guid ProductId { get; set; }

        public decimal PricePerUnit { get; set; }

        public decimal Quantity { get; set; }
    }
}