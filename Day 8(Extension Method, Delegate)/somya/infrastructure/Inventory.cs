using core;
using System;
using System.Collections;
namespace infrastructure
{
    public class Inventory
    {
        static ArrayList list = new ArrayList();
        static Inventory()
        {
            list.Add(new Product{Title = "Pen", Price = 10, Color = "Blue"});
            list.Add(new Product{Title = "Pencil", Price = 5, Color = "Black"});
            list.Add(new Product{Title = "Eraser", Price = 10, Color = "White"});
            list.Add(new Product{Title = "Marker", Price = 20, Color = "Red"});
            list.Add(new Product{Title = "Graphic", Price = 50, Color = "Green"});

        }
        public void AddProduct(string title, int price, string color)
        {
            list.Add(new Product { Title = title, Price = price, Color = color });
        }
        public override string ToString()
        {
            string str = "Title\t\t" + "Price\t\t" + "Color\n";
            foreach (Product p in list)
            {
                str += p.Title + "\t\t" + p.Price + "\t\t" + p.Color + "\n";
            }
            return str;
        }
    }
}
