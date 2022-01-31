using System;

namespace MathLibrary
{
    namespace MathLibrary
    {
        public static class PrimeChecker
        {
            public static bool IsPrime(int number)
            {
                if (number < 0)
                    throw new ArgumentException("The number to test cannot be a negative number.");
                if (number == 0 || number == 1)
                    return false;
                for (int i = 2; i <= number / 2; i++)
                    if (number % i == 0)
                        return false;
                return true;
            }
        }
    }
}
