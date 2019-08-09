using System;

namespace Calculator
{
    public class AreaCalculate
    {
        public static double TriangleThree(double side_x, double side_y, double side_z)
        {
            double perimeter = side_x + side_y + side_z;
            double area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - side_x) * (perimeter / 2 - side_y) * (perimeter / 2 - side_z));
            return (double)Math.Round(area, 3);
        }
        public static double TriangleTwo(double base_x, double height_y)
        {
            double area = (base_x * height_y) / 2;
            return area = (double)Math.Round(area, 3);
        }
        public static double Rectangle(double side_a, double side_b)
        {
            double area = side_a * side_b;
            return area = (double)Math.Round(area, 3);
        }
        public static double Circle(double r)
        {
            double area = Math.PI * r * r;
            return area = (double)Math.Round(area, 3);
        }
        public static double Square(double a)
        {
            double area = a * a;
            return area = (double)Math.Round(area, 3);
        }
        public static double Torus(double R,double r)
        {
            double area = (R*R-r*r)*Math.PI;
            return area = (double)Math.Round(area, 3);
        }
        public static double Trapezoid(double up_side, double down_side,double height)
        {
            double area = 0.5*(up_side+down_side)*height;
            return area = (double)Math.Round(area, 3);
        }
        public static double Sector(double r, double angle)
        {
            double area = Math.PI * r * r * (angle / 360);
            return area = (double)Math.Round(area, 3);
        }
        public static double Parallelogram(double side_a, double side_b)
        {
            double area = side_a * side_b;
            return area = (double)Math.Round(area, 3);
        }
    }
}