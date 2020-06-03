using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _30_05_exam
{
    public class Drawing
    {
        private Dictionary<int, List<string>> parseFile;
        public Drawing(Dictionary<int, List<string>> parseFile)
        {
           this.parseFile = parseFile;
        }

        public void Draw()
        {
            for (int i=0;i<parseFile.Count(); i++)
            {
                {
                    switch (parseFile[i][2])
                    {
                        case "Top": Console.SetCursorPosition(35, 0); break;
                        case "Bottom": Console.SetCursorPosition(35, 50); break;
                        case "Right": Console.SetCursorPosition(77, 13); break;
                        case "Left": Console.SetCursorPosition(0, 13); break;
                    }
                    switch (parseFile[i][3])
                    {
                        case "Red" : Console.ForegroundColor = ConsoleColor.Red; break;
                        case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
                        case "Blue": Console.ForegroundColor = ConsoleColor.Blue; ; break;
                    }
                    WithTimer(parseFile[i][0], parseFile[i][1], parseFile[i][4]);
                }
            }
        }

        public void WithTimer(string firstTime, string secondTime, string showString)
        {
            var firstTimeDigit = int.Parse(firstTime.Split(':').Last().ToString());
            var secondTimeDigit = int.Parse(secondTime.Split(':').Last().ToString());
            var sub = secondTimeDigit - firstTimeDigit;
            DoTime(sub, showString, "00:04", firstTime);
            DoTime(sub, showString, "00:01", firstTime);
            DoTime(sub, showString, "00:02", firstTime);
            DoTime(sub, showString, "00:03", firstTime);
        }

        public void DoTime(int sub, string showString, string time, string firstTime)
        {
            if (time==firstTime)
            {
                Console.WriteLine(showString);
                Thread.Sleep(sub * 1000);
                Console.Clear();
            }
        }
    }
}
