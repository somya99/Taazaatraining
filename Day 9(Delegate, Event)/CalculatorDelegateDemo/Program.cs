using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult res = new PrintResult();
            Addition add = new Addition();
            Subtraction sub = new Subtraction();
            Multiplication mul = new Multiplication();
            Division div = new Division();
            int n1 = 15;
            int n2 = 5;
            PrintResult.Result calculate = add.Add;
            res.GetResult(calculate, n1, n2);
            calculate += sub.Subtract;
            res.GetResult(calculate, n1, n2);
            calculate += mul.Multiply;
            res.GetResult(calculate, n1, n2);
            calculate += div.Divide;
            res.GetResult(calculate, n1, n2);
            Console.ReadKey(true);
        }
    }
}
