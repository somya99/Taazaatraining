using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realTimeEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(c);
            

            Inventory Inv = new Inventory();
            Inv.Subscribe(c);
            c.Run();
        }
    }
}
