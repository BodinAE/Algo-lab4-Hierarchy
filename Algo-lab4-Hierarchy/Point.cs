using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy
{
    internal class Point
    {
        public string Name {  get; set; }
        public decimal x {  get; set; }
        public decimal y { get; set; }
        public override string ToString()
        {
            return $"x: {x}\ty: {y}";
        }

        public Point(decimal x = 0, decimal y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Print()
        {
            Console.WriteLine($"x:\t{x}\ny:\t{y}");
        }
    }
}
