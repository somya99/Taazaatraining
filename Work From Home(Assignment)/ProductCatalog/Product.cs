using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }
        //public Category Categories { get; set; }
        //public string Description { get; set; }
        public int SellingPrice { get; set; }

        public override string ToString()
        {
            return "ID = " + ID + " , Name = " + Name + " , Manufacturer = "  + Manufacturer + " , Short Code = " + ShortCode + " , Selling Price " + SellingPrice;
        }
    }
}
