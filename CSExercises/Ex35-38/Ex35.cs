using System;
using System.Linq;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            int count = 0;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int[] vowelCount = new int[5];
            foreach (char ch in phrase)
            {
                char c = Char.ToLower(ch);
                if (vowels.Contains(c))
                {
                    count ++;
                }
                for (int i = 0; i < 5; i++) 
                {
                    if (c == vowels[i])
                    {
                        vowelCount[i] ++;
                    }    
                }
            }

            Console.WriteLine("Total number of vowels: " + count);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}",vowels[i],vowelCount[i]);
            }
        }
    }
}
