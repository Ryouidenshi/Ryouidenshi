using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            ThreeDigitalNumber();
        }
        static void ThreeDigitalNumber()
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 100 && a<999)
            {
                while (a!= 0)
                {
                    Console.Write(a % 10);
                    a = a / 10;
                }
                
            }
            else Console.WriteLine("Нарушение");
                
        }
    }
}
