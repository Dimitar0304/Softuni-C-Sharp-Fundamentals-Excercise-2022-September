using System;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            string[] arr = new string[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = (items[i]);
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
