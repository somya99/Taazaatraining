using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class CategoryDetails
    {
        public List<Category> category = new List<Category>
        {
            new Category
            {
                ID = 1,
                Name = "Stationary",
                ShortCode = "STN",
            },
            new Category
            {
                ID = 2,
                Name = "Food",
                ShortCode = "FD",
            },
            new Category
            {
                ID = 3,
                Name = "Crockery",
                ShortCode = "CRK",
            }
        };
        private static int Id = 3;

        static int IncreaseId()
        {
            return ++Id;
        }
        public void DisplayCategory()
        {
            Console.WriteLine("List of Category");
            foreach (Category c in category)
            {
                Console.WriteLine(c);
            }
        }
        public void AddCategory()
        {
            int newId = IncreaseId();
            Console.WriteLine("Enter Category Name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter unique Category Short Code");
            string newShortCode = Console.ReadLine();

            category.Add(new Category
            {
                ID = newId,
                Name = newName,
                ShortCode = newShortCode               
            });

        }
        public void DeleteCategory()
        {
            Console.WriteLine("Enter Category ID");
            int id = Convert.ToInt32(Console.ReadLine());
            category.RemoveAt(id);
            DisplayCategory();
            //Console.WriteLine("Enter Category Short Code");
            //string shortc = Console.ReadLine();
            //category.Remove(shortc);
            //DisplayCategory();
        }
        public void SearchCategory()
        {
            Console.WriteLine("Search by Following Property: ");
            Console.WriteLine("\t a) ID");
            Console.WriteLine("\t b) Name");
            Console.WriteLine("\t c) Short Code");
            Console.WriteLine("Enter an option : ");
            string option = Console.ReadLine();

            if (option == "a")
            {
                Console.WriteLine("Enter ID");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Category c in category)
                {
                    if (c.ID == id)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else if (option == "b")
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                foreach (Category c in category)
                {
                    if (c.Name == name)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else if (option == "c")
            {
                Console.WriteLine("Enter Short Code");
                string shortcode = Console.ReadLine();
                foreach (Category c in category)
                {
                    if (c.ShortCode == shortcode)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            
        }
    }
}
