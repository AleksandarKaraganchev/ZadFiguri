using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadFiguri
{
    public class Trapezoid
    {
        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        private double h;
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Trapezoid(double a, double b, double h)
        {
            this.A = a;
            this.B = b;
            this.H = h;
        }
        public void Print()
        {
            Console.WriteLine($"The face of the trapezoid is {((a + b) * h) / 2}");
        }
    }
}
