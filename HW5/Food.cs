using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace HW5
{
    public class Food : Product
    {
        public DateTime ExpirationDate { get; set; }

        public double Quantity { get; set; }

        public string Unit { get; set; } = "";
    }
}
