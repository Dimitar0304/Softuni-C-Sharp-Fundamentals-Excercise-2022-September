using System;

namespace _04TribonacciSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            // num input
            //first add first three elements in the sequance
            // while
            //create tribonacci sequance array
            //create var nextnum for sum the nexttribonacii num with n1+n2+n3
            //for loop from 4  to <=num

            int num = int.Parse(Console.ReadLine());

            uint[] tribonacciSequance = new uint[num];
            if (num==3)
            {
                tribonacciSequance[0] = 1;
                tribonacciSequance[1] = 1;
                tribonacciSequance[2] = 2;
            }
            else if (num==2)
            {
                tribonacciSequance[0] = 1;
                tribonacciSequance[1] = 1;
            }
            else if (num == 1)
            {
                tribonacciSequance[0] = 1;
            }
            if (num>3)
            {
                tribonacciSequance[0] = 1;
                tribonacciSequance[1] = 1;
                tribonacciSequance[2] = 2;
                for (int i = 3; i < num; i++)
                {
                    uint n1 = 0;
                    uint n2 = 0;
                    uint n3 = 0;

                    AddOtherElements(n1, n2, n3, tribonacciSequance, i);
                }
            }
          
            
        }

        private static void AddOtherElements(uint n1, uint n2, uint n3, uint[] tribonacciSequance, int i)
        {
            n1 = tribonacciSequance[i-1];
            n2 = tribonacciSequance [i - 2];
            n3 = tribonacciSequance[i - 3];
            uint nextNum = n1 + n2 + n3;
            tribonacciSequance[i] = nextNum;
        }
    }
}
