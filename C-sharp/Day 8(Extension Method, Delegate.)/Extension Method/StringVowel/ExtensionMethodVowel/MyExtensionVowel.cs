using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodVowel
{
    public static class MyExtensionVowel
    {
        public static int Vowel(this string str)
        {
            int count = 0;
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
