﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_lab4_Hierarchy
{
    internal class Line : Shape
    {
        public Point Pos1 {  get; set; }
        public Point Pos2 { get; set; }
        public decimal Length { get; set; }
        
        public Line(string name = "Line", decimal x1 = 0, decimal y1 = 0, decimal x2 = 0, decimal y2 = 0) 
        { 
            this.Name = name;
            Pos1 = new Point(x1, y1);
            Pos2 = new Point(x2, y2);
            MiddlePos = new Point((x1 + x2) / 2, (y1 + y2) / 2);
            Length = Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)))));
        }

        public Line(string name, Point start, Point end)
        {
            this.Name = name;
            MiddlePos = new Point((start.x + end.x) / 2, (start.y + end.y) / 2);
            Length = Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(((end.x - start.x) * (end.x - start.x)) + ((end.y - start.y) * (end.y - start.y)))));
        }

        public void Print() 
        {
            Console.WriteLine($"Line:\t{Name}");
            MiddlePos.Print();
            Console.WriteLine($"Starting point:\t{Pos1}\nEnding point:\t{Pos2}\nLength:\t{Length}");
            
        }
        public override string ToString()
        {
            return $"Line: {this.Name}\tStart: {Pos1}\tEnd: {Pos2}";
        }
    }
}