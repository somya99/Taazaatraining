using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>
            {
                new Product
                {
                    ID = 1,
                    Title = "Pen",
                    Price = 400,
                    Owner = "foo"
                },
                new Product
                {
                    ID = 2,
                    Title = "Pencil",
                    Price = 100,
                    Owner = "koo"
                },
                new Product
                {
                    ID = 3,
                    Title = "Eraser",
                    Price = 600,
                    Owner = "abc"
                },
                new Product
                {
                    ID = 4,
                    Title = "Hilighter",
                    Price = 500,
                    Owner = "xyz"
                },
                new Product
                {
                    ID = 5,
                    Title = "Ruler",
                    Price = 300,
                    Owner = "def"
                },
            };
            var owners = prod.Where(p => p.Price > 300).Select(p => p.Owner).ToList();
            owners.ForEach(o => Console.WriteLine(o));
            //gives owner name of product having price > 300 (Lambda expression)

            var sq = from pr in prod where pr.Price > 300 select pr.Owner;
            sq.ToList().ForEach(item => Console.WriteLine(item));
            //gives owner name of product having price > 300 (LINQ query)

            var owners1 = prod.Where(p1 => p1.Price > 300).Select(p1 => (p1.ID, p1.Owner)).ToList();
            owners1.ForEach(o1 => Console.WriteLine(o1));
            //gives id and owner name of product having price > 300 (Lambda expression)

            var sq1 = from pr1 in prod where pr1.Price > 300 select (pr1.ID, pr1.Owner);
            sq1.ToList().ForEach(item1 => Console.WriteLine(item1));
            //gives id and owner name of product having price > 300 (LINQ query)

            var owners2 = prod.Where(p2 => p2.Price > 300).Select(p2 => new { p2.ID, p2.Owner }).ToList();
            owners2.ForEach(o2 => Console.WriteLine(o2));
            //gives id and owner name of product having price > 300 making it as a new object(Lambda expression)

            var sq2 = from pr2 in prod where pr2.Price > 300 select new { pr2.ID, pr2.Owner };
            sq2.ToList().ForEach(item2 => Console.WriteLine(item2));
            //gives id and owner name of product having price > 300 making it as a new object(LINQ query)

            Console.ReadKey(true);
        }
    }
}
