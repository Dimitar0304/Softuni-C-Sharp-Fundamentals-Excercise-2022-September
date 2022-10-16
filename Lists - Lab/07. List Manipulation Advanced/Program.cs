using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isCheked = false;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string comand = inputParams[0];
                if (comand == "Add")
                {
                    isCheked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (comand == "Remove")
                {
                    isCheked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (comand == "RemoveAt")
                {
                    isCheked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);

                }
                else if (comand == "Insert")
                {
                    isCheked = true;
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                }
                else if (comand == "Contains")
                {
                    int value = int.Parse(inputParams[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comand == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(x=> x % 2==0)));
                }
                else if (comand == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (comand == "GetSum")
                {
                    Console.WriteLine(string.Join(" ",numbers.Sum()));
                }
                else if (comand =="Filter")
                {
                    string condition = inputParams[1];
                    int value = int.Parse(inputParams[2]);
                    if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ",numbers.Where(x=> x > value)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }
                    else if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));
                    }
                }

                input = Console.ReadLine();

            }
            if (isCheked == true)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }

        }
    }
}
