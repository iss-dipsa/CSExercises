using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(SQT(i));
            }
        }

        public static double SQT(int y)
        {
            Random random = new Random();
            double g = random.NextDouble() * (y - 1) + 1;

            while (Math.Abs(g * g - y) > 0.00001)
            {
                g = (g + y / g) / 2;
            }

            return g;
        }
    }
}
