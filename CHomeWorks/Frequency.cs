using Microsoft.Diagnostics.Runtime.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CHomeWorks
{
    public class Frequency
    {
        public static void FrequencyMethod()
        {
            string path = "C:\\Users\\craas\\Text.txt";

            var wordList = new List<string>();
            var wordCountDictionary = new Dictionary<string, int>();

            var wordValues = new List<int>();

            List<int> maxTen = new List<int>();
            List<string> frequentlWords = new List<string>();

            int minFromMaxTen;

            using (var sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().ToLower();
                
                text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

                string[] words = text.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                wordList.AddRange(words);

                for (int i = 1; i < wordList.Count; i++)
                {
                    if (!wordCountDictionary.ContainsKey(wordList[i]))
                    {
                        wordCountDictionary.Add(wordList[i], 1);
                    }
                    else
                    {
                        wordCountDictionary[wordList[i]]++;
                    }
                }

                foreach (var value in wordCountDictionary.Values)
                {
                    wordValues.Add(value);
                }

                wordValues.Sort();
                wordValues.Reverse();

                for (int i = 0; i < 10; i++)
                {
                    maxTen.Add(wordValues[i]);
                }

                minFromMaxTen = maxTen.Min();

                var orderDictionary = wordCountDictionary.OrderByDescending(x => x.Value).Where(x => x.Value >= minFromMaxTen);

                foreach (var value in orderDictionary)
                {
                    Console.WriteLine(value.Key);
                }

            }   
                
        }
    }
}
