using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var item in numbers)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{counts.Keys} -> {counts.Values}");
            }
        }
    }
}
