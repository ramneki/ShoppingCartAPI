using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingCart.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int CheckoutId { get; set; }
        public int BookId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Book Book { get; set; }
        public virtual Checkout Checkout { get; set; }
    }
}
