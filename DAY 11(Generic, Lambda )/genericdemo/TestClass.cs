using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdemo
{
    public class TestClass<T>
    {
        T[] obj = new T[5];
        int count = 0;
        public void Add(T item)
        {
            if(count + 1 < 6)
            {
                obj[count] = item;
            }
            count++;
        }
        public T this[int index]
        {
            get
            {
                return obj[index];
            }
            set
            {
                obj[index] = value;
            }
        }
    }
}
