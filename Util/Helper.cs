namespace Util
{
    public class Helper
    {
        static Random random = new Random();

        /// <summary>
        /// Prints the current date time using console
        /// </summary>
        public static string fnPrintDateTimeNow() => DateTime.Now.ToString();

        /// <summary>
        /// Generates a string using lowercase chars
        /// </summary>
        /// <param name="iLength">Length of string to return</param>
        /// <returns></returns>
        public static string fnGenerateString(int iLength)
        {
            string strChars = "abcdefghijklmnopqrstuvwxyz";
            char[] arrChars = new char[iLength];
            for (int i = 0; i < iLength; i++)
            {
                arrChars[i] = strChars[random.Next(strChars.Length)];
            }

            return new string(arrChars);
        }
    }
}