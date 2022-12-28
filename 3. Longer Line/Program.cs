using System;

namespace _3._Longer_Line
{
    class Program
    {
        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first <= secound)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
              
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        static void Main(string[] args)
        {
            // 8 numbers 2 * 2  + 2* 2 we will get longer line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            // method for get longer line 
            GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPairs = 0; //2* 2
            double secondPairs = 0;// 2 * 2
            firstPairs = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            secondPairs = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);

            //if check 
            if (firstPairs >= secondPairs)
            {
                ClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosestPoint(x3, y3, x4, y4);
            }
        }
    }
}
