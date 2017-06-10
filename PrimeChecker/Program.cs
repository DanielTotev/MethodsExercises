namespace PrimeChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            CheckIFPrime(n);
        }
        public static void CheckIFPrime(long number)
        {
            bool isPrime = true;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }
    }
}
