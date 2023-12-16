using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Point
    {
        private double a;
        private double b;
        private string c;

        public Point(double a, double b, string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
        }

        public double B
        {
            get { return b; }
        }

        public string C
        {
            get { return c; }
        }
    }

    class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            double sideLength = Math.Sqrt(Math.Pow(B.a - A.a, 2) + Math.Pow(B.b - A.b, 2));
            return sideLength;


        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;

                double sideLength = GetSideLength(points[i], points[nextIndex]);
                perimeter += sideLength;
            }

            Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 3, "B");
            Point point3 = new Point(4, 0, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.CalculatePerimeter();

            Point point4 = new Point(0, 0, "A");
            Point point5 = new Point(0, 4, "B");
            Point point6 = new Point(3, 4, "C");
            Point point7 = new Point(3, 0, "D");

            Figure quadrilateral = new Figure(point4, point5, point6, point7);
            quadrilateral.CalculatePerimeter();

            Console.ReadLine();

        }
    }
}
