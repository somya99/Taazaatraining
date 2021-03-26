using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMessage
{
    public static class SendTypes
    {
        public static bool SendByEmail(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by Email to {m.Address}");
            return true;
        }
        public static bool SendByCar(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by Car to {m.Address}");
            return true;
        }
        public static bool SendByShip(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by Ship to {m.Address}");
            return false;
        }
    }
}
