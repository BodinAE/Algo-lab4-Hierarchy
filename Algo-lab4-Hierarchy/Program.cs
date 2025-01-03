﻿using Algo_lab4_Hierarchy.Aggregation;
using Algo_lab4_Hierarchy.Inheritance;

namespace Algo_lab4_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var test = new Rectangle("Rect1", 0, 0, 2, 6);
            //test.Print();
            //Console.WriteLine("---------");
            //var sq1 = new Square("Sqar1", 0, 0, 10);
            //sq1.Print();
            //var lin = new Line("Lin1", 0, 0, 3, 4);
            //var lin2 = new Interval("Int1", 0, 0, 3, 4);
            //lin.Print();
            //lin2.Print();
            //var test = new Interval("inter", 0, 0, 1, 1);
            //Console.WriteLine(test.GetSize());
            //Point test2 = test;
            //Console.WriteLine(test2.GetSize());
            //var test3 = new Triangle("tri", 0, 0, 1, 0, 1, 1);
            //Console.WriteLine(test3.GetSize());
            var test = new SquareTriangle("test", 3, 3, 1, 3);
            test.Print();
            Point pointtest = new Point(4, 4);
            Point intetest = new Interval("inttest", 5, 5, 6, 6);
            Console.WriteLine(pointtest.GetSize());
            Console.WriteLine(intetest.GetSize());
        }
    }
}
