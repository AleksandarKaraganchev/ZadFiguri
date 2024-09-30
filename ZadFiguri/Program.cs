using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using ZadFiguri;

namespace Rectagle
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Rectagle> rectagles = new List<Rectagle>();
            List<Triangle> triangles = new List<Triangle>();
            List<Square> squares = new List<Square>();
            List<Trapezoid> trapezoids = new List<Trapezoid>();
            List<Parallelogram> parallelograms = new List<Parallelogram>();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Option (1) Rectagle");
            Console.WriteLine("Option (2) Triangle");
            Console.WriteLine("Option (3) Square");
            Console.WriteLine("Option (4) Trapezoid");
            Console.WriteLine("Option (5) Parallelogram");
            Console.Write("Choose option:");
            short chooseoption = short.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (chooseoption == 1)
            {
                Console.Write("How many rectagles do you want to enter: ");
                short numofRectagles = short.Parse(Console.ReadLine());
                for (int i = 0; i < numofRectagles; i++)
                {
                    Console.Write("Enter lenght: ");
                    double lenght = double.Parse(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());
                    Rectagle rectagle = new Rectagle(lenght, width);
                    rectagles.Add(rectagle);
                }
                Console.Clear();

                foreach (Rectagle rectag in rectagles)
                {
                    rectag.Print();
                }
            }
            if (chooseoption == 2)
            {
                Console.Write("How many triangles do you want to add: ");
                short numofTriangles = short.Parse(Console.ReadLine());
                for (int i = 0; i < numofTriangles; i++)
                {
                    Console.Write("Enter a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter c: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(a, height, b, c);
                    triangles.Add(triangle);
                }
                Console.Clear();
                foreach (Triangle triangle in triangles) { triangle.Print(); };
            }
            if (chooseoption == 3)
            {
                Console.Write("Enter how many squares you want to add: ");
                short numsquares = short.Parse(Console.ReadLine());
                for (int i = 0; i < numsquares; i++)
                {
                    Console.Write("Enter a: ");
                    double a = double.Parse(Console.ReadLine());
                    Square square = new Square(a);
                    squares.Add(square);
                }
                Console.Clear();
                foreach (Square square in squares)
                {
                    square.Print();
                }
            }
            if (chooseoption == 4)
            {
                Console.Write("How many trapezoids you want to add?: ");
                short numtrapezoids = short.Parse(Console.ReadLine());
                for (int i = 0; i < numtrapezoids; i++)
                {
                    Console.Write("Enter a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter h: ");
                    double h = double.Parse(Console.ReadLine());
                    Trapezoid trapezoid = new Trapezoid(a, b, h);
                    trapezoids.Add(trapezoid);
                }
                Console.Clear();
                foreach (Trapezoid trapezoid in trapezoids)
                {
                    trapezoid.Print();
                }
            }
            if (chooseoption == 5)
            {
                Console.Write("Enter how many parallelograms you want to add: ");
                short numparallelograms = short.Parse(Console.ReadLine());
                for (int i = 0; i < numparallelograms; i++)
                {
                    Console.Write("Enter a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter ha:");
                    double h = double.Parse(Console.ReadLine());
                    Parallelogram parallelogram = new Parallelogram(a, h);
                    parallelograms.Add(parallelogram);
                }
                Console.Clear();
                foreach (Parallelogram circle in parallelograms)
                {
                    circle.Print();
                }
            }
            if (chooseoption > 5 || chooseoption < 1)
            {
                Console.WriteLine("Enter an option in the correct format!!!");
            }
        }
    }
}
