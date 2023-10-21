using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    class Triangle
    {
        public double SideA { get; set; }
        public double SideBase { get; set; }
        public double SideC {  get; set; }  
        public double TriangleHeight { get; set; }

        public Triangle(double A, double Base, double C, double Height)
        {
            SideA = A;
            SideBase = Base;
            SideC = C;
            TriangleHeight = Height;
        }

        public void TriangleMeasurements()
        {
            Console.WriteLine($"Side A's length of the triangle is: {SideA}");
            Console.WriteLine($"The Base of the triangle is: {SideBase}");
            Console.WriteLine($"Side C's length of the triangle is: {SideC}");
            Console.WriteLine($"The Height of the triangle is: {TriangleHeight}");
        }


        public double TriangleCircum()
        { 
            return SideA + SideBase + SideC;
        }

        public double TriangleArea() 
        {
            return (TriangleHeight * SideBase) / 2;
        }
    }
}
