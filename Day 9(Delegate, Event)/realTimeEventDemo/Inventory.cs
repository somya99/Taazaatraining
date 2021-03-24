using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realTimeEventDemo
{
    public class Inventory
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(InventoryTimeHasChanged);
        }
        public void InventoryTimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Inventory Time : {0} : {1} : {2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
