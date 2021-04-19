using Lift.Entities;
using System;

namespace Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] rawInput = new int[][] {
                new int[] {}, //0
                new int[] {6, 5, 2}, //1
                new int[] {4}, //2
                new int[] {}, //3
                new int[] {0, 0, 0}, //4
                new int[] {}, //5
                new int[] {}, //6
                new int[] {3, 6, 4, 5, 6}, //7
                new int[] {}, //8
                new int[] {1, 10, 2}, //9
                new int[] {1, 4, 3, 2}, //10
            };

            int liftCapacity = 4;

            var building = new Building(liftCapacity, rawInput);
        }
    }
}
