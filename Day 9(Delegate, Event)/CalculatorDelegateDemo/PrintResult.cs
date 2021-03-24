using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDelegateDemo
{
    public class PrintResult
    {
        public delegate int Result(int num1, int num2);
        public void GetResult(Result ans, int num1, int num2)
        {
            var status = ans(num1, num2);
            Console.WriteLine("Result is " + status);
        }
    }
}
