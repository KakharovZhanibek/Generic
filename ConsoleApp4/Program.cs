using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "Вот дом, Который построил Джек. А это пшеница, Которая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] arr = str.Split(new Char[] { ',', '.', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, uint> dict = new Dictionary<string, uint>();
            
            foreach (var word in arr)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict.Add(word, 1);
            }
            int x = 1;
            Console.WriteLine("\tСлово:\t\tКоличество:");
            foreach (var i in dict)
            {
                Console.WriteLine("{0}.\t{1}\t\t{2}", x, i.Key, i.Value);
                x++;
            }
            Console.WriteLine("Всего слов: {0} Из них уникальных {1}",arr.Length,dict.Count);
        }
    }
}
