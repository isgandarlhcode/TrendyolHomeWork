using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trendyol
{
    class Payment
    {
        public void makePayment()
        {
            int paymentID = GetHashCode();
            Console.WriteLine("Kartinizin adini daxil edin : ");
            CardName = Console.ReadLine();
            Console.WriteLine("Kartinizin nomresini daxil edin : ");
            CardNumber = Console.ReadLine();
            Console.WriteLine("Kartinizin etibarliliq muddetini daxil edin : ");
            CardValidDate = Console.ReadLine();
            Console.WriteLine("Kartinizin 3D Secure kodunuzu daxil edin : ");
            Card3DNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("...................");
            Thread.Sleep(1500);
            Console.WriteLine("...................");
            Thread.Sleep(1500);

            Console.WriteLine("");

            Console.WriteLine("Odenis muveffeqiyyetle heyata kecirildi .");
        }

        public int PaymentID { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        
        public string CardValidDate { get; set; }

        public int Card3DNumber { get; set; }


    }
    }
