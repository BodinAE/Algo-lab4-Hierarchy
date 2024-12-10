using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy.Inheritance
{
    internal class Triangle : Interval // inh
    {
        public decimal x3 { get; set; }
        public decimal y3 { get; set; }
        public Triangle(string name = "Triangle", decimal x1 = 0, decimal y1 = 0, decimal x2 = 0, decimal y2 = 0, decimal x3 = 0, decimal y3 = 0)
        {
            Name = name;
            x = x1;
            y = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public decimal GetSize()
        {
            decimal a = Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y))));
            decimal b = Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3))));
            decimal c = Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x3 - x) * (x3 - x) + (y3 - y) * (y3 - y))));
            decimal s = (a + b + c) / 2;
            return Convert.ToDecimal(Math.Sqrt(decimal.ToDouble(s * (s - a) * (s - b) * (s - c))));
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
