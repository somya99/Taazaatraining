using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideToString
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; } 

        public override string ToString()
        {
            return "Person name: " + Name + ", Age: " + Age + ", Grade: " + Grade;
        }
    }
}
