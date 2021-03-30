using System;
using infrastructure;
using core;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory ob = new Inventory();
            Console.WriteLine(ob.ToString());

            Product pr = new Product
            {
                Title = "Acrylic Paint",
                Price = 300,
                Color = "Multi"
            };
            Console.WriteLine(pr.display());
        }
    }
}
