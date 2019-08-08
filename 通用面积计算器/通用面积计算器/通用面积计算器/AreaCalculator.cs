using System;

namespace 通用面积计算器
{
    public class AreaCalculator
    {
        float TriangleThree(float x, float y, float z)
        {
            float cir = x+y+z;
            float area = Math.Sqrt(cir / 2 * (cir / 2 - x) * (cir / 2 - y) * (cir / 2 - z));
            return area = (float)Math.Round(area, 3);
        }
        float TriangleTwo(float x, float y)
        {
            float area = 0.5 * x * y;
            return area = (float)Math.Round(area, 3);
        }
        float Rectangle(float a,float b)
        {
            float area = a * b;
            return area = (float)Math.Round(area, 3);
        }
        float Circle(float r)
        {
            float area = Math.PI * r * r;
            return area = (float)Math.Round(area, 3);
        }
    }
}