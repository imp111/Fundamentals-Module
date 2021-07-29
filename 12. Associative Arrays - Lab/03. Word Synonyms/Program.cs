using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                }

                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
