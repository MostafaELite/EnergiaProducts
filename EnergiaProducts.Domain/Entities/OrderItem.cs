using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaProducts.Domain.Entities
{
    public class OrderItem
    {
        public Guid OrderId { get; }

        public Guid ProductId { get; }

        public decimal Quantity { get; }

    }
}
