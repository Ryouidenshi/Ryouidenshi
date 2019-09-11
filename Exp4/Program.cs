using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int count = 0;
            Console.WriteLine(" Введите число");
            int a = int.Parse(Console.ReadLine());
            for (int i=1; i<=a;i++)
                {
                if (a % i == 0 && x == 0)
                    x = i;
                if (a % i == 0 && x != 0 && y == 0)
                    y = i;
                }


            if (a % x ==0 & a % y ==0 & x!=0 & y!=0)
                    {
                        int N = int.Parse(Console.ReadLine());
                        while (a<N)
                             {
                                 a = a + 1;
                                 count = count + 1;
                             }

                    }
            
            Console.WriteLine(count + " Количество чисел, меньших N");

        }
    }
}
