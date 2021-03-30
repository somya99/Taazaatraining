using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQzip
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
            List<Distributor> dis = new List<Distributor>
            {
                new Distributor
                {
                    Name = "dis1",
                    DID = 21,
                    PId = 8
                },
                new Distributor
                {
                    Name = "dis2",
                    DID = 22,
                    PId = 2
                },
                new Distributor
                {
                    Name = "dis3",
                    DID = 23,
                    PId = 3
                },
                new Distributor
                {
                    Name = "dis4",
                    DID = 24,
                    PId = 9
                },
                new Distributor
                {
                    Name = "dis5",
                    DID = 25,
                    PId = 5
                },

            };

            var res = prod.Zip(dis, (p, d) => p.PID + d.Name).ToList();
            res.ForEach(o => Console.WriteLine(o));
            
            Console.ReadKey(true);
        }
    }
}
