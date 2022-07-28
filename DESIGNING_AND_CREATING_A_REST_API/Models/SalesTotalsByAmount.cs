using System;
using System.Collections.Generic;

namespace DESIGNING_AND_CREATING_A_REST_API.Models
{
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime? ShippedDate { get; set; }
    }
}
