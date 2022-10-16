using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> seecondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int n = Math.Min(firstList.Count, seecondList.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(firstList[i]);
                result.Add(seecondList[i]);
            }
            if (firstList.Count > seecondList.Count)
            {
                for (int i = n; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = n; i < seecondList.Count; i++)
                {
                    result.Add(seecondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
