using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A a = new A();
            a.display();
            a.display2();
            B b = new B();
            b.display();
            b.display2();
        }
    }
}
