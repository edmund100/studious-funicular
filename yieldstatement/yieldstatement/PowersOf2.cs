using System;
namespace yieldstatement
{
    public class PowersOf2
    {
        public static void ShowPowers()
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 5))
            {
                Console.Write("{0} ", i);
            }
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        // Output: 2 4 8 16 32 64 128 256
    }
}
