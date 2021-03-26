using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            Message m1message = new Message
            {
                Address = "Hudson, Ohio",
                Content = "Task completed have a nice day!"
            };
            Manager.sendMessageDelegate md = SendTypes.SendByCar;
            m1.RequestDelivery(m1message, md);
            Agent a = new Agent();

            a.notificationChanged += new Agent.NotificationHandler(ShowNotification);
            Console.ReadKey(true);
        }
        public static void ShowNotification(object theClock, NotificationEventArgs e)
        {
            Console.WriteLine(e.status);
        }
        
    }
}
