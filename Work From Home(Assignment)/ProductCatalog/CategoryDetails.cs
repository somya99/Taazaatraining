using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog
{
    public class CategoryDetails
    {
        //List of category
        public static List<Category> category = new List<Category>
        {
            new Category
            {
                Name = "Stationary",
                ShortCode = "STN",
                Description = "Used to create"
            },
            new Category
            {
                Name = "Food",
                ShortCode = "FD",
                Description = "Used to eat"
            },
            new Category
            {
                Name = "Crockery",
                ShortCode = "CRK",
                Description = "Used in kitchen"
            }
        };
        //operations
        public void level2Category()
        {
            Console.WriteLine("LEVEL 2");
            Console.WriteLine("\t a) Enter a Category");
            Console.WriteLine("\t b) List all Categories");
            Console.WriteLine("\t c) Delete a Category");
            Console.WriteLine("\t d) Search a Category");
            Console.WriteLine("\t e) LEVEL 1");
            Console.WriteLine("Enter an option : ");
            string optionC = Console.ReadLine();
            if (optionC == "a")
            {
                AddCategory();
            }
            else if (optionC == "b")
            {
                DisplayCategory();
               
            }
            else if (optionC == "c")
            {
                DeleteCategory();
            }
            else if (optionC == "d")
            {
                SearchCategory();
            }
            else if(optionC == "e")
            {
                Console.Clear();
            }
        }
        //display category
        public void DisplayCategory()
        {
            Console.WriteLine("List of Category");
            foreach (Category c in category)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
        //add category
        public void AddCategory()
        {            
            Console.WriteLine("Enter Category Name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter unique Category Short Code");
            string newShortCode = Console.ReadLine();
            manageShortCode(newShortCode);
            Console.WriteLine("Enter Category Description");
            string des = Console.ReadLine();
            category.Add(new Category
            {
                Name = newName,
                ShortCode = newShortCode,
                Description = des
            });
            DisplayCategory();
            
        }
        public void manageShortCode(string shortc)
        {
            
            category.ForEach((element) =>
            {
                if (element.ShortCode == shortc)
                {
                    Console.WriteLine("Already used! Try something else");
                    string elseshortcode = Console.ReadLine();
                    manageShortCode(elseshortcode);
                }
            });
            
        }
        //delete category
        public void DeleteCategory()
        {
            Console.WriteLine("Select a property by which you want to delete");
            Console.WriteLine("\t a) ID");
            Console.WriteLine("\t b) Short Code");
            Console.WriteLine("Enter an option : ");
            string option = Console.ReadLine();

            if(option == "a")
            {
                Console.WriteLine("Enter Category ID");
                int id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    var data = category.Single((element) => element.ID == id);
                    category.Remove(data);
                    DisplayCategory();
                }
                catch
                {
                    Console.WriteLine("ID does not exist");
                }
                
            }
            else if(option == "b")
            {
                Console.WriteLine("Enter Category Short Code");
                string shortc = Console.ReadLine();
                try
                {
                    var data = category.Single((element) => element.ShortCode == shortc);
                    category.Remove(data);
                    DisplayCategory();
                }
                catch
                {
                    Console.WriteLine("Short Code does not exist");
                }
                
            }
            Console.ReadKey();
        }
        //search category
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
                bool flag = false;
                foreach (Category c in category)
                {
                    if (c.ID == id)
                    {
                        Console.WriteLine(c);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("ID does not exist");
                }
            }
            else if (option == "b")
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                bool flag = false;
                foreach (Category c in category)
                {
                    if (c.Name == name)
                    {
                        Console.WriteLine(c);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("ID does not exist");
                }
            }
            else if (option == "c")
            {
                Console.WriteLine("Enter Short Code");
                string shortcode = Console.ReadLine();
                bool flag = false;
                foreach (Category c in category)
                {
                    if (c.ShortCode == shortcode)
                    {
                        Console.WriteLine(c);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("ID does not exist");
                }
            }
            
        }
    }
}
