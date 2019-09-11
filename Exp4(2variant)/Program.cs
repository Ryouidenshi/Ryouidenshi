using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp4_2variant_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите число");
            int N=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите X");
            int X=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y");
            int Y=int.Parse(Console.ReadLine());
            for (int i=0;i<=N;i++)
              {
                if (i % X == 0 || i % Y == 0)
                    count = count + 1;
              }
            Console.WriteLine(count + " Количество чисел меньших N, которые имеют простые делители X или Y.");
        }
    }
}
