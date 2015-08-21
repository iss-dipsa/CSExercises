using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\tY");
            Console.WriteLine("------------");
            for (int i = -5; i <= 5; i++)
            {
                double d = i;
                Console.WriteLine("{0:0.0##}\t{1:0.0##}", d, ((2 * d * d) - (4 * d) + 3));
            }

            for (int i = -5; i <= 5; i++)
            {
                double d = i;
                double times = (2*d*d) - (4*d) + 3;

                for (int j = (int)times; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
