using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pangram_checker
{
    class Program
    {
        static List<char> checkPangram(string userinput)
        {
            int count = 0;
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> missingLetters = new List<char>();

            foreach (char x in alphabet)
            {
                if (userinput.Contains(x))
                {
                    count++;
                }
                else
                {
                    missingLetters.Add(x);
                }
            }
            return missingLetters;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string input = Console.ReadLine().ToLower();
            List<char> newmissingLetters = checkPangram(input);
            if (newmissingLetters.Count == 0)
            {
                Console.WriteLine("This sentence is a pangram.");
            }
            else
            {
                Console.WriteLine("You are missing {0} letters for it to be a pangram: ", newmissingLetters.Count);
                foreach (char x in newmissingLetters)
                {
                    if (newmissingLetters.Last() == x) //checks if it is the last value to put a full stop or not.
                    {
                        Console.Write(x + ".");
                    }
                    else
                    {
                        Console.Write(x + ", ");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
