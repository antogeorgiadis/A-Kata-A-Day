using System;

namespace CSharp
{
    class IsPrimeNumber
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
            {
                if (number % i == 0)  return false;
            }

            return true;
        }
    }
}