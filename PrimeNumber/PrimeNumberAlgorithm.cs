namespace PrimeNumber
{
    internal class PrimeNumberAlgorithm
    {
        /// <summary>
        /// Method to calculate if the number is a prime number or not.
        /// </summary>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            var zero = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    zero++;
                }
            }
            if (zero == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
