using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class ProductDetails
    {
        public List<Product> product = new List<Product>
        {
            new Product
            {
                ID = 1,
                Name = "Cup",
                Manufacturer = "Ele",
                ShortCode = "CUP",
                SellingPrice = 100
            },
            new Product
            {
                ID = 2,
                Name = "Pen",
                Manufacturer = "George",
                ShortCode = "PEN",
                SellingPrice = 90
            },
            new Product
            {
                ID = 3,
                Name = "Bread",
                Manufacturer = "Stephen",
                ShortCode = "BRD",
                SellingPrice = 170
            },
            new Product
            {
                ID = 4,
                Name = "Plate",
                Manufacturer = "Ele",
                ShortCode = "PLT",
                SellingPrice = 250
            },
            new Product
            {
                ID = 5,
                Name = "Pencil",
                Manufacturer = "George",
                ShortCode = "PNCL",
                SellingPrice = 50
            }

        };
        private static int Id = 5;

        static int IncreaseId()
        {
            return ++Id;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("List of Products");
            foreach(Product p in product)
            {
                Console.WriteLine(p);
            }
        }
        public void AddProduct()
        {
            int newId = IncreaseId();
            Console.WriteLine("Enter Product Name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter Product Manufacturer");
            string newManufacturer = Console.ReadLine();
            Console.WriteLine("Enter unique Product Short Code");
            string newShortCode = Console.ReadLine();
            Console.WriteLine("Enter Product Selling Price greater than 0");
            int newSellingPrice = Convert.ToInt32(Console.ReadLine());

            product.Add(new Product
            {
                ID = newId,
                Name = newName,
                Manufacturer = newManufacturer,
                ShortCode = newShortCode,
                SellingPrice = newSellingPrice
            });

        }
        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product ID");
            int id = Convert.ToInt32(Console.ReadLine());
            product.RemoveAt(id - 1);
            DisplayProduct();
            //Console.WriteLine("Enter Product Short Code");
            //string shortc = Console.ReadLine();
            //product.Remove(shortc);
            //DisplayProduct();
        }
        public void SearchProduct()
        {
            Console.WriteLine("Search by Following Property: ");
            Console.WriteLine("\t a) ID");
            Console.WriteLine("\t b) Name");
            Console.WriteLine("\t c) Short Code");
            Console.WriteLine("\t d) Selling Price");
            Console.WriteLine("Enter an option : ");
            string option = Console.ReadLine();

            if(option == "a")
            {
                Console.WriteLine("Enter ID");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach(Product p in product)
                {
                    if(p.ID == id)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            else if (option == "b")
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                foreach (Product p in product)
                {
                    if (p.Name == name)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            else if (option == "c")
            {
                Console.WriteLine("Enter Short Code");
                string shortcode = Console.ReadLine();
                foreach (Product p in product)
                {
                    if (p.ShortCode == shortcode)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            else if (option == "d")
            {
                Console.WriteLine("Enter Selling Price");
                int price = Convert.ToInt32(Console.ReadLine());
                foreach (Product p in product)
                {
                    if (p.SellingPrice >= price)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
        }
    }
}
