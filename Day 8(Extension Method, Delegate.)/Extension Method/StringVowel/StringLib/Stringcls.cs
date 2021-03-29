using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class Stringcls
    {
        private int count;
        public string str { get; set; }

        public int Count()
        {
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
