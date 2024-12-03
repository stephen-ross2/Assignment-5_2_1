namespace Assignment_5_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to determine the length of the last word: ");
            string input = Console.ReadLine();

            int lengthOfLastWord = LengthOfLastWord(input);
            Console.WriteLine($"The length of the last word is: {lengthOfLastWord} characters");
        }
        
        public static int LengthOfLastWord(string s)
        {
            int length = 0;
            int i = s.Length - 1;
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}

