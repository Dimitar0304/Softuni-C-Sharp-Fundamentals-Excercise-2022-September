using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
              int  nums = int.Parse(Console.ReadLine());
                num[i] = nums;

            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]+" " );
            }
        }
    }
}
