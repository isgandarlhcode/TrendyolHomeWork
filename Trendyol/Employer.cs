using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Employer:Person
    {
        public void EmployerAdder()
        {
            employerNumber = GetHashCode();
            Console.WriteLine("Isci olaraq daxil oldugunuz .");
            Console.WriteLine("................................");
            Console.WriteLine("Hansi vezifede isleyirsiniz ? :");
            employerType = Console.ReadLine();
        }

        public int employerNumber { get; set; }
        public string employerType { get; set; }
    }
}
