using EnergiaProducts.Models.Requests;

namespace EnergiaProducts.Domain.Models
{
    //Just to make it clear, Request here doesn't mean HTTP Request
    public class PlaceOrderRequest
    {
        public string CashierName { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal Change { get; set; }

        public IEnumerable<OrderedItem> OrderedProducts { get; set; }
    }
}