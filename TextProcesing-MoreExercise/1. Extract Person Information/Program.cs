using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            //n lines of input 
            // we have to know in every string name and years to current people
            // the name is between @ and |
            // the age is between # and *
            // foreach founded name print => "{name} is {age} years old."
            // create dictionary for save name - age
            Dictionary<string, int> peoples = new Dictionary<string, int>();

            string name = string.Empty;
            string age = string.Empty ;

            int indexOfName = 0;
            int indexOfNameEnd = 0;
            int indexOfAge = 0;
            int indexOfAgeEnd = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int y = 0; y < input.Length; y++)
                {
                     indexOfName = input.IndexOf('@');
                    indexOfNameEnd = input.IndexOf('|');
                     indexOfAge = input.IndexOf('#');
                     indexOfAgeEnd = input.IndexOf('*');
                    
                }
                name = input.Substring(indexOfName+1,indexOfNameEnd-indexOfName-1);
                age = input.Substring(indexOfAge+1,indexOfAgeEnd-indexOfAge-1);
                peoples[name] = int.Parse(age);

                
            }






            foreach (var kvp in peoples)
            {
                Console.WriteLine($"{kvp.Key} is {kvp.Value} years old.");
            }
        }
    }
}
