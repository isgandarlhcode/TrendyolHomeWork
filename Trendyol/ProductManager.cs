using System;
using System.Collections.Generic;
using System.Text;
using Trendyol;

namespace Trendyol
{
    class ProductManager
    {
        public void ProductManagerr()
        {

            Product product1 = new Product();
            Console.Write("Mehsulun adini qeyd edin: ");
            product1.Name = Console.ReadLine();
            Console.Write("Mehsulun hansi kateqoriyaya aid oldugunu qeyd edin: ");
            product1.Category = Console.ReadLine();
            Console.Write("Mehsulun kodunu qeyd edin: ");
            product1.BarCode = Console.ReadLine();
            Console.Write("Mehsulun qiymetini qeyd edin: ");
            product1.Cost = Decimal.Parse(Console.ReadLine());
            Console.Write("Mehsulun rengini qeyd edin: ");
            product1.Color = Console.ReadLine();
            Console.WriteLine("Mehsulun olcusunu qeyd edin: ");
            product1.Size = Console.ReadLine();
            Console.WriteLine("Mehsulun materialini qeyd edin: ");
            product1.Material = Console.ReadLine();

            product1.WriteProductInformation();
        }

    }
}
