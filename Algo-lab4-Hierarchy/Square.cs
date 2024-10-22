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
        decimal a { get; set; }
        public Square(string name, Point pos, decimal a)
        {
            this.a = a;
            var x1 = pos.x;
            var y1 = pos.y;
            var x2 = pos.x + a;
            var y2 = pos.y + a;
            Name = name;
            Pos1 = new Point(x1, y1);
            Pos2 = new Point(x1, y2);
            Pos3 = new Point(x2, y2);
            Pos4 = new Point(x2, y2);
            Line1 = new Line($"{name}_L1", Pos1, Pos2);
            Line2 = new Line($"{name}_L2", Pos2, Pos3);
            Line3 = new Line($"{name}_L3", Pos3, Pos4);
            Line4 = new Line($"{name}_L4", Pos4, Pos1);
            MiddlePos = new Point((x1 + x2) / 2, (y1 + y2) / 2);
            Area = a * a;
        }

        public void Print()
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
