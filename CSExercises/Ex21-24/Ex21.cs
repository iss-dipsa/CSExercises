using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("Enter a number (1-100): ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != 88);

            Console.WriteLine("Lucky you");

        }
    }
}
