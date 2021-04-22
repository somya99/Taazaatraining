using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controlout = false;
            while (!controlout)
            {
                Console.WriteLine("LEVEL 1");
                Console.WriteLine("\t a) Category");
                Console.WriteLine("\t b) Product");
                Console.WriteLine("\t c) Exit the App!");

                Console.WriteLine("Enter an option : ");
                string option = Console.ReadLine();
                if (option == "a")
                {
                    CategoryDetails category = new CategoryDetails();
                    category.level2Category();
                }
                else if (option == "b")
                {
                    ProductDetails product = new ProductDetails();
                    product.level2Product();
                }
                else if (option == "c")
                {
                    return;
                }
                Console.Clear();
            }
            
        }
        
    }
}
