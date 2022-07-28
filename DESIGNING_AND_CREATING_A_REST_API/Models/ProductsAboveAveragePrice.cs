using System;
using System.Collections.Generic;

namespace DESIGNING_AND_CREATING_A_REST_API.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
