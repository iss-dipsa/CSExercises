using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = "";
            bool toUpper = true;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (toUpper)
                {
                    newphrase += Char.ToUpper(phrase[i]);
                    toUpper = false;
                }
                else
                {
                    newphrase += phrase[i];
                }

                if (phrase[i] == ' ')
                {
                    toUpper = true;
                }
            }

            Console.WriteLine(newphrase);
        }
    }
}
