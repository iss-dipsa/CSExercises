using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for (int n = 1; n < 10000; n++)
            {
                bool isPrime = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(n);
                }
            }
            
        }
    }
}
