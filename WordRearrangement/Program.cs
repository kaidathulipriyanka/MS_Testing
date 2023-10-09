namespace WordRearrangement
{
    public class Program
    { 
        public static string CheckEligibilityForNextRound(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return "No";
            }

            // Convert words to character arrays for easy sorting and comparison
            char[] word1Chars = word1.ToCharArray();
            char[] word2Chars = word2.ToCharArray();

            Array.Sort(word1Chars);
            Array.Sort(word2Chars);

            // Check if the sorted character arrays are equal
            if (new string(word1Chars) == new string(word2Chars))
            {
                return "YES";
            }

            return "No";
        }

        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }}