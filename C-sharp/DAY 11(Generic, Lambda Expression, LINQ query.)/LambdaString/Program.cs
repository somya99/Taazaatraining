using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "That large animals require luxuriant vegetation has been a general assumption which has passed from one work to another, but I do not hesitate to say that it is completely false and that it has vitiated the reasoning of geologists on some points of great interest in the ancient history of the world. The prejudice has probably been derived from India, and the Indian islands, where troops of elephants, noble forests, and impenetrable jungles are associated together in everyone’s mind. If, however, we refer to any work of travels through the southern parts of Africa, we shall find allusions in almost every page either to the desert character of the country or to the numbers of large animals inhabiting it. The same thing is rendered evident by the many engravings which have been published in various parts of the interior.";
            var common = str.Split(' ');
            var res = common.Where(word => word == "in").Count(); // Lambda expression
            Console.WriteLine(res);

            var sq = (from c in common where c == "to" select c).Count(); // LINQ query
            Console.WriteLine(sq);

            Console.ReadKey(true);
        }
    }
}
