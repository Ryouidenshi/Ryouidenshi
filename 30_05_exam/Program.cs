using System.IO;


namespace _30_05_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("text.txt");
            var parsingFiles = new Parsing(file).GetParseCommands();
            var drawer = new Drawing(parsingFiles);
            drawer.Draw();
        }
    }
}
