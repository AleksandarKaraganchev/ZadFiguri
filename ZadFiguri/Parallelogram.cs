using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadFiguri
{
    public class Parallelogram
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double h;

        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Parallelogram(double a, double h)
        {
            this.A = a;
            this.H = h;
        }
        public void Print()
        {
            Console.WriteLine($"The face of the parallelogram is {a * h}");
        }
    }
}
