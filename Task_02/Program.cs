using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        //Convert a string to an array
        public static string[] StringToArray(string str)
        {
            // Create placeHolder and the List to be appended.
            string placeHolder = "";
            List<string> words = new List<string>();

            // Loop through all characters in string and store words when ' ''s are detected.
            foreach (char c in str)
            {
                if (c.Equals(' '))
                {
                    words.Add(placeHolder);
                    placeHolder = "";
                    continue;
                }

                placeHolder += c;
            }

            // Add last word from string to words list.
            words.Add(placeHolder);

            // Convert List to Array.
            string[] final = words.ToArray();
            return final;
        }
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
