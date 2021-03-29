using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class B : A
    {
        public override void display()
        {
            Console.WriteLine("class B");
        }

        public new void display2()
        {
            Console.WriteLine("class B2");
        }
    }
}
