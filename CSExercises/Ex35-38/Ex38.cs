using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            int[] marksDesc = new int[] { 0, 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (marks[marksDesc[i]] < marks[marksDesc[j]])
                    {
                        //swap the order 
                        var temp = marksDesc[i];
                        marksDesc[i] = marksDesc[j];
                        marksDesc[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}", names[marksDesc[i]], marks[marksDesc[i]]);
            }

            Console.WriteLine();

            int[] namesAsc = new int[] { 0, 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (String.Compare(names[namesAsc[i]], names[namesAsc[j]], StringComparison.Ordinal) > 0)
                    {
                        //swap the order 
                        var temp = namesAsc[i];
                        namesAsc[i] = namesAsc[j];
                        namesAsc[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}", names[namesAsc[i]], marks[namesAsc[i]]);
            }
        }
    }
}
