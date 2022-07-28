using System;
using System.Collections.Generic;

namespace DESIGNING_AND_CREATING_A_REST_API.Models
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
