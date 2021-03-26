using System;
using CalculatorLib;
using StringLib;

namespace ExternMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator
            {
                Num1 = 6,
                Num2 = 9
            };
            var ans = c1.Mul();
            Console.WriteLine(ans);
            
            string a = "somyadas";
            Console.WriteLine(a.Vowel());
            
        }
    }
}
