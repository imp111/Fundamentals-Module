using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine()
               .Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in sentence)
            {
                string lower = word.ToLower();

                if (counts.ContainsKey(lower))
                {
                    counts[lower]++;
                }
                else
                {
                    counts.Add(lower, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.WriteLine(count.Key + " ");
                }
            }
        }
    }
}
