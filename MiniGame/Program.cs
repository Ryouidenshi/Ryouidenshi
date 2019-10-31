using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ToMoveAndFlag();
        }
        public static void ToMoveAndFlag()
        {
            int count = 0;
            Random ran = new Random();
            int playerX = ran.Next(3, 60);
            int playerY = ran.Next(3, 20);
            int flagX = ran.Next(3, 20);
            int flagY = ran.Next(3, 20);
            Console.CursorVisible = false;
            ConsoleKeyInfo button;
            do
            {
                //Console.Beep();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(flagX, flagY);
                Console.Write((char)1);
                Console.SetCursorPosition(playerX, playerY);
                Console.Write((char)6);
                Console.SetCursorPosition(1, 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\r{0}", " Ваши очки: " + count);
                Console.ResetColor();
                Console.SetCursorPosition(62, 22);
                Console.WriteLine("Наберите 10 очков");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                CreateWalls(20, playerX, playerY);
                Console.ResetColor();
                button = Console.ReadKey(true);
                if (button.Key == ConsoleKey.UpArrow)
                    playerY--;
                if (button.Key == ConsoleKey.DownArrow)
                    playerY++;
                if (button.Key == ConsoleKey.RightArrow)
                    playerX++;
                if (button.Key == ConsoleKey.LeftArrow)
                    playerX--;
                if (flagX == playerX && flagY == playerY)
                {
                    if (count < 9)
                    {
                        count += 1;
                        flagX = ran.Next(3, 60);
                        flagY = ran.Next(3, 21);
                    }                   
                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("ВЫ БАЛБЕС ");
                        Console.ResetColor();
                        break;
                    }
                }                                                                   
                if ((playerX<=79 && playerY==22 && playerX>=62) || (playerY==1 && playerX>=1 && playerX<12))
                    {
                        playerX=5;
                        playerY=5;
                    }                   
            } while (button.Key != ConsoleKey.Escape);
            Console.CursorVisible = true;
            Console.ReadKey();
        }
        public static void Counter()
        {
            int count = 1;
            if (count < 2)
            {
                count += 1;
                Console.SetCursorPosition(Console.WindowWidth - 20, Console.WindowHeight - 20);
                Console.Write("\r{0}", count);
            }
        }

        public static void CreateWalls(int sizeWalls, int playerX, int playerY)
        {
            var startPointX = 0;
            var startPointY = 0;
            for (; startPointX < Console.WindowWidth - 1; startPointX++)
            {
                Console.SetCursorPosition(startPointX, startPointY);
                Console.Write("#");
                if (playerX == startPointX && playerY == startPointY)
                {
                    Console.Clear();
                    Console.SetCursorPosition(1, 1);
                    CreateBalbes();
                }
            }
            for (; startPointY < 23; startPointY++)
            {
                Console.SetCursorPosition(startPointX, startPointY);
                Console.Write("#");
                if (playerX == startPointX && playerY == startPointY)
                    {
                        CreateBalbes();
                    }
            }
            for (; startPointX > 0; startPointX--)
            {
                Console.SetCursorPosition(startPointX, startPointY);
                Console.Write("#");
                if (playerX == startPointX && playerY == startPointY)
                    {
                        CreateBalbes();
                    }
            }
            for (; startPointY > 0; startPointY--)
            {
                Console.SetCursorPosition(startPointX, startPointY);
                Console.Write("#");
                if (playerX == startPointX && playerY == startPointY)
                    {
                        CreateBalbes();
                    }
            }
        }
        public static void CreateBalbes()
        {                               
            while (true)
                Console.WriteLine("ВЫ БАЛБЕС    ВЫ БАЛБЕС      ВЫ БАЛБЕС         ВЫ БАЛБЕС     ВЫ БАЛБЕС "); 
            Environment.Exit(0);                   
        }
    }   
}