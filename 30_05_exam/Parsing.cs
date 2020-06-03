using System;
using System.Collections.Generic;
using System.Linq;


namespace _30_05_exam
{
    public class Parsing
    {
        private string[] file;
        public Parsing(string[] file)
        {
            this.file = file;
        }
        public Dictionary<int,List<string>> GetParseCommands()
        {
            var result = new Dictionary<int, List<string>>();
            for (int i = 0; i < file.Count(); i++)
            {
                var listCommands=(file[i].Split(new char[] { '[', ',', ' ', '-', ']' },
                    StringSplitOptions.RemoveEmptyEntries).ToList());
                result.Add(i,listCommands);
            }
            return result;
        }
    }
}
