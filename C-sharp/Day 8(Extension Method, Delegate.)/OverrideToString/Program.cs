using System;

namespace OverrideToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person 
            { 
                Name = "George", 
                Age = 12,
                Grade = 6
            };
            Console.WriteLine(person);
        }
    }
}
