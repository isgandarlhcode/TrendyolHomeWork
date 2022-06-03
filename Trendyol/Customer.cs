using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Customer : Person
    {
        public void CustomerAdder()
        {
            customerNumber = GetHashCode();
            Console.WriteLine("Musteri olaraq daxil oldugunuz .");
            Console.WriteLine("................................");
            Console.WriteLine("Hansi tip musterilik isteyirsiniz ? : Silver / GOLD");
            customerType = Console.ReadLine();
        }

        public int customerNumber { get; set; }
        public string customerType { get; set; }

    }
}
