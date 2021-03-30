using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>
            {
                new Product
                {
                    PID = 1,
                    Title = "Pen",
                    Price = 400,
                    Owner = "foo"
                },
                new Product
                {
                    PID = 2,
                    Title = "Pencil",
                    Price = 100,
                    Owner = "koo"
                },
                new Product
                {
                    PID = 3,
                    Title = "Eraser",
                    Price = 600,
                    Owner = "abc"
                },
                new Product
                {
                    PID = 4,
                    Title = "Hilighter",
                    Price = 500,
                    Owner = "xyz"
                },
                new Product
                {
                    PID = 5,
                    Title = "Ruler",
                    Price = 300,
                    Owner = "def"
                },
            };
            Cal<int> ical = new Cal<int>
            {
                echo = 9
            };
            ical.Display(new Action(() => Console.WriteLine(ical.echo * ical.echo)));

            Cal<Product> pcal = new Cal<Product>
            {
                echo = new Product
                {
                    PID = 5,
                    Title = "Ruler",
                    Price = 300,
                    Owner = "def"
                }
            };

            ical.Display(new Action(() => Console.WriteLine(pcal.echo.Price)));
            Console.ReadKey(true);
        }
    }
}
