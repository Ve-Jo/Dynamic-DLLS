using System.Text.RegularExpressions;

namespace ClassLibrary2
{
    public class Text
    {
        public static bool IsPalindrome(string text)
        {
            text = text.ToLower();

            string cleanedText = new string(text.Where(char.IsLetter).ToArray());

            char[] chars = cleanedText.ToCharArray();

            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] != chars[chars.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountSentences(string text)
        {
            string pattern = @"[.!?]";

            string[] sentences = Regex.Split(text, pattern);

            sentences = sentences.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            return sentences.Length;
        }

        public static string Reverse(string text)
        {
            char[] chars = text.ToCharArray();

            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            return new string(chars);
        }
    }
    
}