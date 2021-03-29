using System;
using System.Collections.Generic;
using System.Text;
using CalculatorLib;


namespace ExternMethodDemo
{
    public static class MyExtensionMethod
    {
        public static int Mul(this Calculator c)
        {
            int res = c.Num1 * c.Num2;
            return res;
        }
        
    }
}
