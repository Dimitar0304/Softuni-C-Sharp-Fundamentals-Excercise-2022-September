using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] line1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] line2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < line1.Length; i++)
            {
                if (line1[i]!=line2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    break;
                }
                else
                {
                    int currNum = line1[i];
                    sum += currNum;
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
   
            }
          
        }
    }
}
