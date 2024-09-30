using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectagle
{
    public class Square
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public Square(double a)
        {
            this.A = a;
        }
        public void Print()
        {
            Console.WriteLine($"The face of the square is {a * a}\n The Parameter is {a + a + a + a}");
        }
    }
}
