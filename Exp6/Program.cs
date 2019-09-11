using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A (от пряммой AB)");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B (от пряммой AB)");
            int x1= int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки M (Точка на плоскости)");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            double d=Math.Abs((y1 - y)*y2 - (x1 - x)*x2 + y1*x - y1*x) / Math.Sqrt(Math.Pow(y1 - y, 2) + Math.Pow(x1 - x, 2));
            Console.WriteLine(d);
        }
  
    }
}
