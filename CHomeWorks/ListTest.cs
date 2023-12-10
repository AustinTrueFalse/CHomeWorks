using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CHomeWorks
{
    public class ListTest
    {
        public static void ListTestMethod()
        {
            //Timer
            var stopWatch = Stopwatch.StartNew();

            //List
            var listTest = new List<string>();

            //ReadFile
            string text = File.ReadAllText("C:\\Users\\craas\\Text.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            //ListInput
            listTest.AddRange(words);

            Console.WriteLine($"Время на создание массива из файла: {stopWatch.Elapsed.TotalMilliseconds}");           
        }
    }
}
