using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n)
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sorted[i]);

                if (sorted.Length < 3)
                {
                    if (i == 1)
                    {
                        break;
                    }
                }
            }
        }
    }
}
