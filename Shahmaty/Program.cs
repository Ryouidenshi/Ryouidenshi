using System;
using System.Collections.Generic;


namespace Shahmaty
{
    class Shahmaty
    {
        public static bool IsPawn(string begin, string end)
        {
            return (Math.Abs(begin[1]-end[1])==1 || Math.Abs(begin[0] - end[0]) == 1);
        }
//ffd
        public static bool IsHorse(string[] str)
        {
            var begin = NumberString(str[1]);
            var end = NumberString(str[2]);
            return (Math.Abs(begin-end)==1 || Math.Abs(begin - end) == 3);
        }

        public static bool IsQueen(string begin, string end)
        {
            return (begin == end || Math.Abs(begin[0] - end[0]) == Math.Abs(begin[1] - end[1]) 
                        || begin[0]==end[0] || begin[1]==end[1]);
        }

        public static bool IsBishop(string begin, string end)
        {
            return (Math.Abs(begin[0] - end[0]) == Math.Abs(begin[1] - end[1]));
        }

        public static bool IsRook(string begin, string end)
        {
            return (begin[0] == end[0] || begin[1] == end[1]);
        }

        public static double NumberString(string str)
        {
            var num = 0;
            for (int i=0;i<str.Length;i++)
            {
                num += str[i];
            }
            return num;
        }

        static void Main(string[] args)
        {
            var listCases = new List<string>();
            listCases.Add("P A1 A2");
            listCases.Add("H D5 F6");
            listCases.Add("Q E4 A8");
            listCases.Add("B E5 B2");
            listCases.Add("R B5 H5");
            listCases.Add("P A1 B1");
            listCases.Add("H D5 F9");
            listCases.Add("Q B4 A8");
            listCases.Add("B E5 E2");
            listCases.Add("R A5 A5");
            listCases.Add("P A1 A2");
            listCases.Add("H D5 F9");
            listCases.Add("Q E4 E4");
            listCases.Add("B D2 B2");
            listCases.Add("R B1 H1");
            listCases.Add("P A1 A5");
            listCases.Add("H D3 F6");
            listCases.Add("Q E8 A1");
            listCases.Add("B E2 B2");
            listCases.Add("R B5 H5");
            for (int i = 0; i < listCases.Count; i++)
            {
                var splitString = listCases[i].Split(' ');
                string begin = splitString[1].ToString();
                string end = splitString[2].ToString();
                switch (splitString[0])
                {
                    case ("P"):
                        {
                            Console.WriteLine(listCases[i] + " - Ход пешки или нет - " + IsPawn(begin, end));
                            break;
                        }
                    case ("H"):
                        {
                            Console.WriteLine(listCases[i] + " - Ход коня или нет - " + IsHorse(splitString));
                            break;
                        }
                    case ("Q"):
                    {
                        Console.WriteLine(listCases[i] + " - Ход королевы или нет - " + IsQueen(begin, end));
                        break;
                    }
                    case ("B"):
                        {
                            Console.WriteLine(listCases[i] + " - Ход слона или нет - " + IsBishop(begin, end));
                            break;
                        }
                    case ("R"):
                        {
                            Console.WriteLine(listCases[i] + " - Ход ладьи или нет - " + IsRook(begin, end));
                            break;
                        }
                    default:
                        {
                            throw new Exception("Ошибка");
                            break;
                        }                     
                }
            }

        }
    }
    
}
