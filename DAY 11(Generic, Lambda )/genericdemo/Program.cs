using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> intObj = new TestClass<int>();
            intObj.Add(5);
            intObj.Add(15);
            intObj.Add(25);
            intObj.Add(8);
            intObj.Add(12);

            TestClass<Product> products = new TestClass<Product>();

            products.Add(new Product
            {
                ID = 1,
                Title = "Pen",
                Price = 20
            });
            products.Add(new Product
            {
                ID = 2,
                Title = "Pencil",
                Price = 10
            });
            products.Add(new Product
            {
                ID = 3,
                Title = "Eraser",
                Price = 15
            });
            products.Add(new Product
            {
                ID = 4,
                Title = "Hilighter",
                Price = 50
            });
            products.Add(new Product
            {
                ID = 5,
                Title = "Ruler",
                Price = 30
            });
            
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(intObj[i]);
                Console.WriteLine(products[i]);
                }

            Console.ReadKey(true);
        }
    }
}
