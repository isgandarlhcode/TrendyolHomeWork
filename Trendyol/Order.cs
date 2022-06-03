using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Order
    {
        public void orderChecker()
        {
            OrderID = GetHashCode(); ;
        }

        public int OrderID { get; set; }

    }
}
