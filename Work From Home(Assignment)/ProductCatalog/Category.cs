﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Category
    {
        public static int CategoryID = 0;
        public int ID { get; }
        public Category()
        {
            CategoryID++;
            ID = CategoryID;
        }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "ID = " + ID + " , Name = " + Name + " , Short Code = " + ShortCode + " , Description = " + Description;
        }
    }
}
