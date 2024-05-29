using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractical240524
{
    public static class StringUtils
    {
        public static string Reverse(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ToUpperCase(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.ToUpper();
        }
        public static bool IsPalindrome(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            string reversed = Reverse(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
