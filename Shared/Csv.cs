using System.Collections.Generic;
using System.IO;

namespace Csv
{
    public class Reader
    {
        public static List<string> ExtractColumn(string path, int column)
        {
            var urls = new List<string> { };

            var allLines = File.ReadAllLines(path);

            foreach (var line in allLines)
            {
                var secondColumn = line.Split(';')[column - 1].Replace('"', ' ');
                urls.Add(secondColumn);
            }

            return urls;

        }
    }
}