using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectagle
{
    public class Rectagle
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public Rectagle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public void Print()
        {
            Console.WriteLine($"The face of the rectagle is {length * width}\n The perimeter is {2 * (length + width)}");
        }
    }
}
