using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergiaProducts.Api.Controllers
{
    public class ApiOrder
    {
        [Required]
        public string CashierName { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal Change { get; set; }

        [Required]
        public IEnumerable<ApiOrderedProduct> OrderedProducts { get; set; }        
    }
}