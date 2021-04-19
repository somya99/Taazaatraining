using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        //public string Description { get; set; }

        public override string ToString()
        {
            return "ID = " + ID + " , Name = " + Name + " , Short Code = " + ShortCode;
        }
    }
}
