using System;
using System.Collections.Generic;
using System.Text;
using core;
using infrastructure;
namespace consoleapp
{
    public static class MyExtenMethod
    {
        public static string display(this Product p)
        {
            string str = "Title = " + p.Title + "\n" + "Price = " + p.Price + "\n" + "Color = " + p.Color + "\n";
            return str;
        }
    }
}
