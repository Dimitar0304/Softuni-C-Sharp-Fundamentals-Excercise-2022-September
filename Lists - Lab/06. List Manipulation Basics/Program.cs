using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] inputParams = input.Split();
                string comand = inputParams[0];
                if (comand == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (comand == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (comand == "RemoveAt")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);

                }
                else if (comand == "Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                }





                input = Console.ReadLine();
                
            }
            Console.WriteLine(string.Join(" " ,numbers)); 
       }
    }
}
