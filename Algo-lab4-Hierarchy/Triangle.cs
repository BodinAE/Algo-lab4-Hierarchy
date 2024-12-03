using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy
{
    internal class Triangle : Interval
    {
        public decimal x3 { get; set; }
        public decimal y3 { get; set; }
        public Triangle(string name = "Triangle", decimal x1 = 0, decimal y1 = 0, decimal x2 = 0, decimal y2 = 0, decimal x3 = 0, decimal y3 = 0)
        {
            Name = name;
            this.x = x1;
            this.y = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3; 
            this.y3 = y3;
        }

        public decimal GetSize()
        {
            return Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(((x2 - x) * (x2 - x)) + ((y2 - y) * (y2 - y)))) * Math.Sqrt(Decimal.ToDouble(((x2 - x3) * (x2 - x3)) + ((y2 - y3) * (y2 - y3))))) / 2;
        }

        public override void Print()
        {
            Console.WriteLine($"{this}\nA: ({x}; {y})\t B: ({x2}; {y2})\t C: ({x3}; {y3})");
        }
        public override string ToString()
        {
            return $"Triangle: {Name}";
        }
    }
}
