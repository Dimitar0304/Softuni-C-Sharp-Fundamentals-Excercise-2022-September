using System;

namespace _01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int value = int.Parse(Console.ReadLine());
                MultiplyyTheInt(value);
               
            }
            else if (input == "real")
            {
                double value = double.Parse(Console.ReadLine());
                MultipltTheDouble(value);
                
            }
            else if (input == "string")
            {
                string value;
                value = Console.ReadLine();
                SurroundTheStrinng(value);
                
            }



        }

        private static void SurroundTheStrinng(string value)
        {
            string result = string.Empty;

             result = $"${value}$";
            Console.WriteLine(result);
        }

        private static void MultipltTheDouble(double value)
        {
            double result = 0;
            result = value * 1.5;
            Console.WriteLine($"{result:F2}") ;
        }

        private static void MultiplyyTheInt(int value)
        {
            int result = 0;
              result = value * 2;
            Console.WriteLine(result);
        }
    }
}
