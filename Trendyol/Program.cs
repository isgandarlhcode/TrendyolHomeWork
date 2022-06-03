using System;

namespace Trendyol
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagePerson person1 = new ManagePerson();
            person1.PersonManager();

            Console.WriteLine("Iscisiniz yoxsa Musteri ?");
            string sorgu = Console.ReadLine();
            if (sorgu == "musteri")
            {
                Customer customer1 = new Customer();
            }

            else
            {
                Employer employer1 = new Employer();
            }

            ProductManager product1 = new ProductManager();
            product1.ProductManagerr();

            Cart cart1 = new Cart();
            cart1.cardChecker();

            Order order1 = new Order();
            order1.orderChecker();

            Payment newpayment = new Payment();
            newpayment.makePayment();

        }
    }
}
