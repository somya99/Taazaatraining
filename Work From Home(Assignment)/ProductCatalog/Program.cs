using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryDetails category = new CategoryDetails();
            ProductDetails product = new ProductDetails();

            Console.WriteLine("LEVEL 1");
            Console.WriteLine("\t a) Category");
            Console.WriteLine("\t b) Product");
            Console.WriteLine("\t c) Exit the App!");

            Console.WriteLine("Enter an option : ");
            string option = Console.ReadLine();
            if(option == "a")
            {
                Console.WriteLine("LEVEL 2");
                Console.WriteLine("\t a) Enter a Category");
                Console.WriteLine("\t b) List all Categories");
                Console.WriteLine("\t c) Delete a Category");
                Console.WriteLine("\t d) Search a Category");
                Console.WriteLine("Enter an option : ");
                string optionC = Console.ReadLine();
                if (optionC == "a")
                {
                    category.AddCategory();
                    category.DisplayCategory();

                }
                else if (optionC == "b")
                {
                    category.DisplayCategory();
                }
                else if(optionC == "c")
                {
                    category.DeleteCategory();
                }
                else if (optionC == "d")
                {
                    category.SearchCategory();
                }
            }
            else if (option == "b")
            {
                Console.WriteLine("LEVEL 2");
                Console.WriteLine("\t a) Enter a Product");
                Console.WriteLine("\t b) List all Product");
                Console.WriteLine("\t c) Delete a Product");
                Console.WriteLine("\t d) Search a Product");
                Console.WriteLine("Enter an option : ");
                string optionP = Console.ReadLine();
                if (optionP == "a")
                {
                    product.AddProduct();
                    product.DisplayProduct();
                }
                else if (optionP == "b")
                {
                    product.DisplayProduct();
                }
                else if (optionP == "c")
                {
                    product.DeleteProduct();
                }
                else if (optionP == "d")
                {
                    product.SearchProduct();
                }
            }
            else if(option == "c")
            {
                Console.ReadKey(false);
            }
        }
    }
}
