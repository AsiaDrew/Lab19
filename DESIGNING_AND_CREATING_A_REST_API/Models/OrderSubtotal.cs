using System;
using System.Collections.Generic;

namespace DESIGNING_AND_CREATING_A_REST_API.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
