using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ToMoveAndFlag();
        }

        public static void SetColorsAndObjects(int playerX, int playerY, int flagX, int flagY, int count, Random ran)
        {
            Console.Clear();
            var monsterX = ran.Next(3, 60);
            var monsterY = ran.Next(3, 15);
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
            CreateMonster(playerX, playerY, count,monsterX, monsterY);
            CheckDie(playerX, playerY, monsterX, monsterY);
        }

        public static void CheckDie(int playerX, int playerY, int monsterX, int monsterY)
        {
            if (Math.Abs(playerX - monsterX) <= 3 && Math.Abs(playerY - monsterY) <= 3)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Thread.Sleep(500);
                Console.WriteLine("ВЫ DIE ");
            }
        }
        public static void MovePlayer(int playerX, int playerY, int flagX, int flagY, int count, Random ran)
        {           
            ConsoleKeyInfo button;
            do
            {
                SetColorsAndObjects(playerX, playerY, flagX, flagY, count, ran);
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
                if ((playerX <= 79 && playerY == 22 && playerX >= 62) || (playerY == 1 && playerX >= 1 && playerX <= 12))
                {
                    playerX = ran.Next(60);
                    playerY = 10;
                }
            } while (button.Key != ConsoleKey.Escape);
        }

        public static void CreateMonster(int playerX, int playerY, int count, int monsterX, int monsterY)
        {
            Console.SetCursorPosition(monsterX, monsterY);
            Console.Write('M');
                if (playerX - monsterX > 0)
                {
                    monsterX++;
                    Console.SetCursorPosition(monsterX, monsterY);                  
                }
                else if (playerX - monsterX < 0)
                {
                    monsterX--;
                    Console.SetCursorPosition(monsterX, monsterY);
 
                }
                else if (playerY - monsterY > 0)
                {
                    monsterY--;
                    Console.SetCursorPosition(monsterX, monsterY);
                }
                else if (playerY - monsterY < 0)
                {
                    monsterY++;
                    Console.SetCursorPosition(monsterX, monsterY);
                }
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
            MovePlayer(playerX, playerY, flagX, flagY, count, ran);
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
                CreateWallObjects(playerX, playerY, startPointX, startPointY);
            }
            for (; startPointY < 23; startPointY++)
            {
                CreateWallObjects(playerX, playerY, startPointX, startPointY);
            }
            for (; startPointX > 0; startPointX--)
            {
                CreateWallObjects(playerX, playerY,startPointX, startPointY);
            }
            for (; startPointY > 0; startPointY--)
            {
                CreateWallObjects(playerX, playerY, startPointX, startPointY);
            }
        }
        public static void CreateWallObjects(int playerX, int playerY, int startPointX, int startPointY)
        {         
                Console.SetCursorPosition(startPointX, startPointY);
                Console.Write("#");
                if (playerX == startPointX && playerY == startPointY)
                {
                    while (true)
                    Console.WriteLine("ВЫ БАЛБЕС    ВЫ БАЛБЕС      ВЫ БАЛБЕС         ВЫ БАЛБЕС     ВЫ БАЛБЕС ");    
                }
        }
    }   
}