using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1_uleran_
{
    class Exp1 //Exp.1 Можно, но не стоит, лишний код мазолит глаза
    {
        static void Main()
        {
            Console.WriteLine(" Введите первую переменную");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Введите вторую переменную");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = b - a;
            b = -b;
            a = (a - b);
            Console.WriteLine(a + " Переменная a");
            Console.WriteLine(b + " Переменная b");
        }
    }
}
