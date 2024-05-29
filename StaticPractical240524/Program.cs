namespace StaticPractical240524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "Racecar";

            Console.WriteLine("Original: " + example);
            Console.WriteLine("Reversed: " + StringUtils.Reverse(example));
            Console.WriteLine("Uppercase: " + StringUtils.ToUpperCase(example));
            Console.WriteLine("Is Palindrome: " + StringUtils.IsPalindrome(example));
        }
    }
}
