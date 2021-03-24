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
        public static int Vowel(this string str)
        {
            int count = 0;
            int len = str.Length;
            for(int i = 0; i < len; i++)
            {
                if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    ++count;
                }
            }
            return count;
        } 
    }
}
