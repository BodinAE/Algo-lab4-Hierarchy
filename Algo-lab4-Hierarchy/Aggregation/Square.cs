using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algo_lab4_Hierarchy.Aggregation
{
    internal class Square 
    {
        Rectangle Rect {  get; set; }
        public string Name
        {
            get
            {
                return Rect.Name;
            }
            set
            {
                Rect.Name = value;
            }
        }
        public Point MiddlePos {
            get
            {
                return Rect.MiddlePos;
            }
            set
            {
                Rect.MiddlePos = value;
            }
        }
        public Line Line1 {
            get
            {
                return Rect.Line1;
            }
            set
            {
                Rect.Line1 = value;
            }
        }
        public Line Line2 {
            get
            {
                return Rect.Line2;
            }
            set
            {
                Rect.Line2 = value;
            }
        }
        public Line Line3 {
            get
            {
                return Rect.Line3;
            }
            set
            {
                Rect.Line3 = value;
            }
        }
        public Line Line4 {
            get
            {
                return Rect.Line4;
            }
            set
            {
                Rect.Line4 = value;
            }
        }
        public decimal Area {
            get
            {
                return Rect.Area;
            }
            set
            {
                Rect.Area = value;
            }
        }

        decimal a { get; set; }                                     //Length of a side
        public Square(string name, decimal middlex, decimal middley, decimal a)
        {
            this.a = a;
            var x1 = middlex - a / 2;
            var y1 = middley - a / 2;
            var x2 = middlex + a / 2;
            var y2 = middley + a / 2;
            Name = name;
            var Pos1 = new Point(x1, y1);
            var Pos2 = new Point(x1, y2);
            var Pos3 = new Point(x2, y2);
            var Pos4 = new Point(x2, y1);
            Line1 = new Line($"{name}_L1", Pos1, Pos2);
            Line2 = new Line($"{name}_L2", Pos2, Pos3);
            Line3 = new Line($"{name}_L3", Pos3, Pos4);
            Line4 = new Line($"{name}_L4", Pos4, Pos1);
            MiddlePos = new Point(middlex, middley);
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
        public decimal GetSize()
        {
            return Area;
        }
        public override string ToString()
        {
            return $"Square: {Name}\tLength: {a}\tArea: {Area}";
        }
    }
}
