namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    newString += c2;
                }
                else
                {
                    newString += s[i];
                }
            }
            return newString;
        }
    }
}
