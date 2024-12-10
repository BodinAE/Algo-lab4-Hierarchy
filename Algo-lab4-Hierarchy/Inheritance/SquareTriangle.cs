using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy.Inheritance
{
    internal class SquareTriangle : Triangle
    {
        public decimal a {  get; set; }
        public decimal b { get; set; }
        public SquareTriangle(string name = "Square Triangle", decimal a = 0, decimal b = 0, decimal x1 = 0, decimal y1 = 0)
        {
            this.Name = name;
            this.a = a;
            this.b = b;
            x = x1;
            y = y1;
            x2 = x1 + a;
            y2 = y1;
            x3 = x1;
            y3 = y1 + b;
        }
        public decimal GetSize()
        {
            decimal a = Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y))));
            decimal b = Convert.ToDecimal(Math.Sqrt(decimal.ToDouble((x3 - x) * (x3 - x) + (y3 - y) * (y3 - y))));
            return a * b / 2;
        }
        public override string ToString()
        {
            return $"SqTriangle: {Name}";
        }
    }
}
