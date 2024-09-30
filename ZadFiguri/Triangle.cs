using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectagle
{
    public class Triangle
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(double a, double height, double b, double c)
        {
            this.A = a;
            this.Height = height;
            this.B = b;
            this.C = c;
        }
        public void Print()
        {
            Console.WriteLine($"The face of the triangle is {(a * height) / 2}\n The Parameter of the Triangle is {a + b + c}");
        }
    }
}
