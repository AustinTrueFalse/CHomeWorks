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

            var wordList = new List<string>();
            var wordCountDictionary = new Dictionary<string, int>();

            var wordValues = new List<int>();

            List<int> maxTen = new List<int>();
            List<string> frequentlWords = new List<string>();


            //ReadFile
            string text = File.ReadAllText("C:\\Users\\craas\\Text.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            //ListInput
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


            foreach (int countNumber in maxTen)
            {
                foreach (var (key, value) in wordCountDictionary)
                {
                    if (wordCountDictionary.ContainsValue(countNumber))
                    {
                        frequentlWords.Add(key);
                    }
                }
            }

            foreach(var word in frequentlWords)
            {
                Console.WriteLine(word);
            }












        }
    }
}
