using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            phrase = phrase.ToLower();

            string newphrase = "";
            string reversephrase = "";

            foreach (char c in phrase)
            {
                if (c != ' ' && c != '.')
                {
                    newphrase = newphrase + c;
                    reversephrase = c + reversephrase;
                }    
            }

            if (newphrase == reversephrase)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
