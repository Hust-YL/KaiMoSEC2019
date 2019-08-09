using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面积计算1
{ class Program
{
    static void Main(string[] args)
    {
        int i; double t_1, t_2, t_3; double r_width ,r_lenth; double cir, area,radius; const double pai = 3.1415926;
            Console.WriteLine("*******欢迎进入几何图形面积计算系统*******");
        while (true)
        {
            Console.WriteLine(" 1.三角形   2.长方形   3.圆形   4.退出 ");
            Console.WriteLine("请输入序号：");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("请输入第一条边长：");
                    t_1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二条边长：");
                    t_2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第三条边长：");
                    t_3 = float.Parse(Console.ReadLine());
                        if (t_1+t_2>t_3&&t_2+t_3>t_1&&t_1+t_3>t_2)
                        {
                            cir = t_1 + t_2 + t_3;
                            area = Math.Sqrt(cir / 2 * (cir / 2 - t_1) * (cir / 2 - t_2) * (cir / 2 - t_3));
                            Console.WriteLine("该三角形面积为：{0}", area);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("输入错误！！！"); break;
                        }
                case 2:
                    Console.WriteLine("请输入长方形的长：");
                    r_lenth = float.Parse(Console.ReadLine());
                    Console.WriteLine("请输入长方形的宽：");
                    r_width = float.Parse(Console.ReadLine());
                        if (r_width <= 0 || r_lenth <= 0)
                        {
                            Console.WriteLine("输入错误！！！"); break;
                        }
                        else
                        {
                            area = r_lenth * r_width;
                            Console.WriteLine("该长方形面积为：{0}", area);
                            break;
                        }
                case 3:
                    Console.WriteLine("请输入圆形半径:");
                    radius= float.Parse(Console.ReadLine());
                        if (radius<=0)
                        {
                            Console.WriteLine("输入错误！！！"); break;
                        }
                        else
                        {
                            area = pai * radius * radius;
                            Console.WriteLine("该圆形面积为：{0}", area);
                            break;
                        }
                    case 4: Console.WriteLine("感谢使用"); break;
                default: Console.WriteLine("输入错误！！！"); break;
            }
            if (i == 4) break;
        }
    }
}
}
