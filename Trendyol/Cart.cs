using System;
using System.Collections.Generic;
using System.Text;
using Trendyol;

namespace Trendyol
{
    class Cart
    {
        public void cardChecker()
        {
            CardID = GetHashCode();;
        }

        public int CardID { get; set; }

    }
}
