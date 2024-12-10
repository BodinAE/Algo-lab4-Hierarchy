using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy.Inheritance
{
    internal class Interval : Point
    {
        public decimal x2 { get; set; }
        public decimal y2 { get; set; }
        //public decimal Length {  get; set; }
        public Interval(string name = "Interval", decimal x1 = 0, decimal y1 = 0, decimal x2 = 0, decimal y2 = 0) : base(x1, y1)
        {
            Name = name;
            x = x1;
            y = y1;
            this.x2 = x2;
            this.y2 = y2;
            //Length = Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)))));
        }
         

        public override decimal GetSize()
        {
            return Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y))));
        }

        public override void Print()
        {
            Console.WriteLine($"{this}\nStart: ({x}; {y})\t End: ({x2}; {y2})");
        }
        public override string ToString()
        {
            return $"Interval: {Name}";
        }
    }
}
