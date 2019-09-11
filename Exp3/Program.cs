using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ВВедите час");
            int a= int.Parse(Console.ReadLine());
            if (a < 24 && a > 0)
                Console.WriteLine(a % 12 * 30);
            else Console.WriteLine("Ошибка");
        }
    }
}
