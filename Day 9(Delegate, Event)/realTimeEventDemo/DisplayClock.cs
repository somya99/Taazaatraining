using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realTimeEventDemo
{
    public class DisplayClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(TimeHasChanged);
        }
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time : {0} : {1} :  {2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
