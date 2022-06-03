using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Product
    {
        public Product()
        {

        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string BarCode { get; set; }
        public decimal Cost { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }


        public void WriteProductInformation()
        {
            StringBuilder info = new StringBuilder();

            info.Append(" Adi : " + this.Name + "\n");
            info.Append(" Kateqoriyasi : " + this.Category + "\n");
            info.Append(" Tip : " + this.Type + "\n");
            info.Append(" Barkod : " + this.BarCode + "\n");
            info.Append(" Qiymeti : " + this.Cost + "\n");
            info.Append(" Rengi :" + this.Color + "\n");

            Console.WriteLine(info);
        }
    }
}
