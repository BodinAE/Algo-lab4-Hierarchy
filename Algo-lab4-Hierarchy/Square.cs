using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy
{
    internal class Square : Shape
    {
        public Point Pos1 { get; set; }
        public Point Pos2 { get; set; }
        public Point Pos3 { get; set; }
        public Point Pos4 { get; set; }
        public Line Line1 { get; set; }
        public Line Line2 { get; set; }
        public Line Line3 { get; set; }
        public Line Line4 { get; set; }

        public decimal Area { get; set; }
        public Square(string name = "Square", decimal x1 = 0, decimal y1 = 0, decimal x2 = 0, decimal y2 = 0)
        {
            Name = name;
            Pos1 = new Point(x1, y1);
            Pos2 = new Point(x1, y2);
            Pos3 = new Point(x2, y2);
            Pos4 = new Point(x2, y2);
            Line1 = new Line($"{name}_L1",Pos1, Pos2);
            Line2 = new Line($"{name}_L2", Pos2, Pos3);
            Line3 = new Line($"{name}_L3", Pos3, Pos4);
            Line4 = new Line($"{name}_L4", Pos4, Pos1);
            MiddlePos = new Point((x1 + x2) / 2, (y1 + y2) / 2);
            Area = Line1.Length * Line2.Length;
        }
    }
}
