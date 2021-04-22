using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog
{
    public class ProductDetails
    {
        //list of product
        public static List<Product> product = new List<Product>
        {
            new Product
            {
                Name = "Cup",
                Manufacturer = "Gala",
                ShortCode = "CUP",
                Categories = "Crockery",
                Description = "Used in kitchen",
                SellingPrice = 100
            },
            new Product
            {
                Name = "Pen",
                Manufacturer = "Classmate",
                ShortCode = "PEN",
                Categories = "Stationary",
                Description = "Used to create",
                SellingPrice = 90
            },
            new Product
            {
                Name = "Bread",
                Manufacturer = "Britannia",
                ShortCode = "BRD",
                Categories = "Food",
                Description = "Used to eat",
                SellingPrice = 170
            },
            new Product
            {
                Name = "Plate",
                Manufacturer = "Gala",
                ShortCode = "PLT",
                Categories = "Crockery",
                Description = "Used in kitchen",
                SellingPrice = 250
            },
            new Product
            {
                Name = "Pencil",
                Manufacturer = "Doms",
                ShortCode = "PNCL",
                Categories = "Stationary",
                Description = "Used to create",
                SellingPrice = 50
            }

        };
        //operations
        public void level2Product()
        {
            Console.WriteLine("LEVEL 2");
            Console.WriteLine("\t a) Enter a Product");
            Console.WriteLine("\t b) List all Product");
            Console.WriteLine("\t c) Delete a Product");
            Console.WriteLine("\t d) Search a Product");
            Console.WriteLine("\t e) LEVEL 1");
            Console.WriteLine("Enter an option : ");
            string optionP = Console.ReadLine();
            if (optionP == "a")
            {
                AddProduct();
            }
            else if (optionP == "b")
            {
                DisplayProduct();
            }
            else if (optionP == "c")
            {
                DeleteProduct();
            }
            else if (optionP == "d")
            {
                SearchProduct();
            }
            else if (optionP == "e")
            {
                Console.Clear();
            }
        }
        //display product
        public void DisplayProduct()
        {
            Console.WriteLine("List of Products");
            foreach(Product p in product)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
        //add product
        public void AddProduct()
        {
            Console.WriteLine("Enter Product Name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter Product Manufacturer");
            string newManufacturer = Console.ReadLine();
            Console.WriteLine("Enter unique Product Short Code");
            string newShortCode = Console.ReadLine();
            manageShortCode(newShortCode);
            Console.WriteLine("Enter a Category among the following");
            CategoryDetails.category.ForEach((element) =>
            {
                Console.WriteLine(element.Name + ",\t");
            });
            string newcategory = Console.ReadLine();
            Console.WriteLine("Enter Product Description");
            string des = Console.ReadLine();
            Console.WriteLine("Enter Product Selling Price greater than 0");
            int newSellingPrice = Convert.ToInt32(Console.ReadLine());

            product.Add(new Product
            {
                Name = newName,
                Manufacturer = newManufacturer,
                ShortCode = newShortCode,
                Categories = newcategory,
                Description = des,
                SellingPrice = newSellingPrice
            });
            DisplayProduct();
            Console.ReadKey();
        }
        public void manageShortCode(string shortc)
        {

            product.ForEach((element) =>
            {
                if (element.ShortCode == shortc)
                {
                    Console.WriteLine("Already used! Try something else");
                    string elseshortcode = Console.ReadLine();
                    manageShortCode(elseshortcode);
                }
            });

        }
        //delete product
        public void DeleteProduct()
        {
            Console.WriteLine("Select a property by which you want to delete");
            Console.WriteLine("\t a) ID");
            Console.WriteLine("\t b) Short Code");
            Console.WriteLine("Enter an option : ");
            string option = Console.ReadLine();

            if (option == "a")
            {
                Console.WriteLine("Enter Product ID");
                int id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    var data = product.Single((element) => element.ID == id);
                    product.Remove(data);
                    DisplayProduct();
                }
                catch
                {
                    Console.WriteLine("ID does not exist");
                }

            }
            else if (option == "b")
            {
                Console.WriteLine("Enter Product Short Code");
                string shortc = Console.ReadLine();
                try
                {
                    var data = product.Single((element) => element.ShortCode == shortc);
                    product.Remove(data);
                    DisplayProduct();
                }
                catch
                {
                    Console.WriteLine("Short Code does not exist");
                }
            }
            Console.ReadKey();
        }
        //search product
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
                bool flag = false;
                foreach(Product p in product)
                {
                    if(p.ID == id)
                    {
                        Console.WriteLine(p);
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("ID does not exist !");
                }
            }
            else if (option == "b")
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                bool flag = false;
                foreach (Product p in product)
                {
                    if (p.Name == name)
                    {
                        Console.WriteLine(p);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Name does not exist !");
                }
            }
            else if (option == "c")
            {
                Console.WriteLine("Enter Short Code");
                string shortcode = Console.ReadLine();
                bool flag = false;
                foreach (Product p in product)
                {
                    if (p.ShortCode == shortcode)
                    {
                        Console.WriteLine(p);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Short Code does not exist !");
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
            Console.ReadKey();
        }
    }
}
