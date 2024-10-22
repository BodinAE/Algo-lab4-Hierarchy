using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy
{
    internal class Shape 
    { 
        public string Name { get; set; }
        public Point MiddlePos {  get; set; }
        //public Shape(string name = "Shape", decimal x = 0, decimal y = 0)
        //{
        //    Name = name;
        //    MiddlePos = new Point(x, y);
        //}
        public override string ToString()
        {
            return $"Shape: {Name}\t{MiddlePos}";
        }
        public void Print() 
        {
            Console.WriteLine($"Shape:\t{Name}");
            MiddlePos.Print();
        }
    }
}
