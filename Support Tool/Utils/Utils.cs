using System;

namespace Support_Tool.Classes
{
    internal class Utils
    {
        internal static string RandomString()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str + ".exe";
        }
    }
}
