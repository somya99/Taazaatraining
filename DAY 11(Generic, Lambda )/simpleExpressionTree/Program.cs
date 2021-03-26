using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = (x) => x * x;
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            var a = e.Compile();
            Console.WriteLine(a(7));
            Console.ReadKey(true);
        }
    }
}
