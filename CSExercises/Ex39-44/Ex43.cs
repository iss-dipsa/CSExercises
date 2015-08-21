namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            char[] hexChars = new char[]
            {
                '0',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                'A',
                'B',
                'C',
                'D',
                'E',
                'F'
            };

            string hex = "";


            do
            {
                int remainder = i % 16;
                hex = hexChars[remainder] + hex;

                i = i/16;

            } while (i > 0);

            return hex;
        }
    }
}
