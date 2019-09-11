using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr1
{
    class Exp5
    {
        static void Main(string[] args)  //Exep.5 (немазохисткая версия)
        {          
            int count = 0;
            Console.WriteLine("Введите год");

            string line = Console.ReadLine();
            while (line != "stop")
                
            {
                
                if (LeapYear(int.Parse(line)))
                {
                    Console.WriteLine("Год весокосный");
                    count=count+1;
                }
             
                else
                    Console.WriteLine("Год не весокосный");
                line = Console.ReadLine();              
            }
            Console.WriteLine(count + " Кол-во высокосных годов" );

            

        }
        static bool LeapYear(int a)
        {
            return (a % 400 == 0) || (a % 4 == 0 && a % 100 != 0);

        }


    }





}
