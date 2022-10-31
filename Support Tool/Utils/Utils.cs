using System;
using System.IO;

namespace Support_Tool.Classes
{
    public class Utils
    {
        public static string RandomString(int numberOfChars)
        {
            if (numberOfChars <= 0) throw new ArgumentException(nameof(numberOfChars));
            string str = null;

            Random random = new Random();
            for (int i = 0; i < numberOfChars; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }

        public static string RandomStringWithSuffix(int numberOfChars, string suffix)
        {
            if (numberOfChars <= 0) throw new ArgumentException("Number of chars must be greater than 0");
            if (string.IsNullOrWhiteSpace(suffix)) throw new ArgumentNullException(nameof(suffix));
            return RandomString(numberOfChars) + suffix;
        }
    }
}
