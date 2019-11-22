using System;
using System.Collections.Generic;

namespace Day27EFCoreDbFirst1.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
