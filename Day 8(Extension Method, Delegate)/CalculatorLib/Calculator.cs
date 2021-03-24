using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        private int Result;

        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Add()
        {
            Result = Num1 + Num2;
            return Result;
        }
        public int Sub()
        {
            Result = Num1 - Num2;
            return Result;
        }
    }
}
