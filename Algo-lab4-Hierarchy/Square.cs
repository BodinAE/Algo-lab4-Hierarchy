using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algo_lab4_Hierarchy
{
    internal class Square : Rectangle
    {
        decimal a { get; set; }                                     //Length of a side
        public Square(string name, decimal middlex, decimal middley, decimal a)
        {
            this.a = a;
            var x1 = middlex - (a / 2);
            var y1 = middley - (a / 2);
            var x2 = middlex + (a / 2);
            var y2 = middley + (a / 2);
            Name = name;
            Pos1 = new Point(x1, y1);
            Pos2 = new Point(x1, y2);
            Pos3 = new Point(x2, y2);
            Pos4 = new Point(x2, y1);
            Line1 = new Line($"{name}_L1", Pos1, Pos2);
            Line2 = new Line($"{name}_L2", Pos2, Pos3);
            Line3 = new Line($"{name}_L3", Pos3, Pos4);
            Line4 = new Line($"{name}_L4", Pos4, Pos1);
            MiddlePos = new Point(middlex, middley);
            Area = a * a;
        }

        public override void Print()
        {
            Console.WriteLine($"Square:\t{Name}");
            MiddlePos.Print();
            Line1.Print();
            Line2.Print();
            Line3.Print();
            Line4.Print();
            Console.WriteLine($"Area:\t{Area}");
        }

        public override string ToString()
        {
            return $"Square: {Name}\tLength: {a}\tArea: {Area}";
        }
    }
}
