using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
            for (int i = 1; i <= 10; i++)
            {
                double d = i;
                Console.WriteLine("{0:0.0##}\t{1:0.0##}\t{2:0.0##}\t{3:0.0##}",d,1/d,Math.Sqrt(d),Math.Pow(d,2));
            }
        }
    }
}
