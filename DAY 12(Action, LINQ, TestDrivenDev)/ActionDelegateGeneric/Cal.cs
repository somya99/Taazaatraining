using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateGeneric
{
    public class Cal<T>
    {
        public T echo { get; set; }
        public void Display(Action a)
        {
            a();
        }
    }
}
