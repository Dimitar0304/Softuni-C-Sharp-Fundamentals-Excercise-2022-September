using System;
using System. Linq;


namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]numbeers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int oddnum = 0;
            int evensum = 0;
            for (int i = 0; i < numbeers.Length; i++)
            {
                int currrentNumber = numbeers[i];
                if (currrentNumber %2==0)
                {
                    evensum += currrentNumber;
                }
                else
                {
                    oddnum += currrentNumber;
                }
            }
            int diff = evensum - oddnum;
            Console.WriteLine(diff);
        }
    }
}
