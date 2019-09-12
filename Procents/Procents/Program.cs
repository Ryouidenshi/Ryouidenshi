using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходную сумму");
            double originalAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент");
            int interestRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяц");
            int depositTerm = int.Parse(Console.ReadLine());
            double total = Calculate(originalAmount, interestRate, depositTerm);
            Console.WriteLine(total);
        }
        public static double Calculate(double originalAmount, int interestRate, int depositTerm)
        {
            return originalAmount + (interestRate / 12.0) * depositTerm;
        }
    }
}
