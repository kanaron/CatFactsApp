using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsLib.Files
{
    public static class FileProcessor
    {

        public static void AddToFile(string line)
        {
            string path = "CatFacts.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(line);
            }
        }

    }
}
