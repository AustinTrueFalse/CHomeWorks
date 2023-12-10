using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace CHomeWorks
{
    public class LinkedTest
    {
        public static void LinkedTestMethod()
        {
            //Timer
            var stopWatch = Stopwatch.StartNew();

            //List
            var linkedListTest = new LinkedList<string>();

            //ReadFile
            string text = File.ReadAllText("C:\\Users\\craas\\Text.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            //ListInput
            foreach (var word in words)
            {
                linkedListTest.AddLast(word);
            }

            Console.WriteLine($"Время на создание массива из файла: {stopWatch.Elapsed.TotalMilliseconds}");          
        }
    }
}
