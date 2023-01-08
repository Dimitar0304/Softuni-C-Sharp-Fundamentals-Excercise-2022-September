using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.we will decrypt messige 
            Dictionary<string, string> typesAndCordinates = new Dictionary<string, string>();
            //first we recive key(sequance of ints)
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // then we recive strings while input== find
            string input = Console.ReadLine();
            int result = 0;
            int counter = 0;
            
            string decryptMessige = string.Empty;
            while (input!="find")
            {

                //we looping recived string char by char and decrease asci code with corespodenting key
                //we loop and key sequance to know which key corespondenting to current char
                //formula for decrypt => char(asci) - (currentKey)=>(char)result
                // if keySequance lenght is smaller than string lenght we start looping curentKey at
                // begginig in keySequance
                for (int i = 0; i < input.Length; i++)
                {
                    int currentCharCode = (int)input[i];
                    result = currentCharCode - keys[counter];
                    decryptMessige += (char)result;
                    counter++;
                    if (counter == keys.Length)
                    {
                        counter = 0;
                    }
                }
                counter = 0;
                
                for (int d = 0; d < decryptMessige.Length; d++)
                {
                    int startIndexOfType = decryptMessige.IndexOf('&');
                    int endIndexOfType = decryptMessige.LastIndexOf('&');
                    int startCordinatesIndex = decryptMessige.IndexOf('<');
                    int endCordinatesIndex = decryptMessige.LastIndexOf('>');
                    string type = decryptMessige.Substring(startIndexOfType + 1, endIndexOfType - startIndexOfType - 1);
                    string cordinates = decryptMessige.Substring(startCordinatesIndex + 1, endCordinatesIndex - startCordinatesIndex - 1);
                    typesAndCordinates[type] = cordinates;
                }
                decryptMessige = string.Empty;

                //2. we will found type of tresure and its cordinates at decrypted messige

                // type of tresure is between char symbol '&'
                // cordinates of current tresure are between '<' and '>'



                input = Console.ReadLine();
            }
            foreach (var item in typesAndCordinates)
            {
                Console.WriteLine($"Found {item.Key} at {item.Value}");
            }
            
        }
    }
}
