using System.Runtime;
using System.Text;
using Util;

namespace CodeTest
{
    public static class Program
    {

        public static int countSubstrings(string input_str)
        {
            int iTotalValue = 0;
            int iSum;

            // Get Substring
            List<string> listStrings = fnSubString(input_str, input_str.Length);

            Parallel.ForEach(listStrings, str =>
            {
                iSum = fnCharMappedToNumber(str);
                if (iSum % str.Length == 0)
                    Interlocked.Add(ref iTotalValue, 1);

            });
            return iTotalValue;
        }

        static List<string> fnSubString(string str, int n)
        {
            List<string> listStrings = new List<string>();
            for (int len = 1; len <= n; len++)
            {
                for (int i = 0; i <= n - len; i++)
                {
                    listStrings.Add(str.Substring(i, len));
                }
            }
            return listStrings;
        }

        private static Dictionary<char, int> charMap = new Dictionary<char, int>{
            { 'a', 1},
            { 'b', 1},
            { 'c', 2},
            { 'd', 2},
            { 'e', 2},
            { 'f', 3},
            { 'g', 3},
            { 'h', 3},
            { 'i', 4},
            { 'j', 4},
            { 'k', 4},
            { 'l', 5},
            { 'm', 5},
            { 'n', 5},
            { 'o', 6},
            { 'p', 6},
            { 'q', 6},
            { 'r', 7},
            { 's', 7},
            { 't', 7},
            { 'u', 8},
            { 'v', 8},
            { 'w', 8},
            { 'x', 9},
            { 'y', 9},
            { 'z', 9},
        };

        public static int fnCharMappedToNumber(string strInput)
        {
            int iCharsTotalValue = 0;

            foreach (char cChar in strInput)
            {
                if (charMap.TryGetValue(char.ToLower(cChar), out int iCharValue))
                    iCharsTotalValue += iCharValue;
            }
            return iCharsTotalValue;
        }

        static void Main(string[] args)
        {
            // Prepare
            string strRandomGenerateInput = Helper.fnGenerateString(2000);
            Console.WriteLine($"Start: {Helper.fnPrintDateTimeNow()}");

            // Execute
            Console.WriteLine($"Result: {countSubstrings(strRandomGenerateInput)}");
            Console.WriteLine($"End: {Helper.fnPrintDateTimeNow()}");

            Console.ReadLine();
        }
    }
}