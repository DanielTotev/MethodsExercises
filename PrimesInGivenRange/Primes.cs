namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;
    public class Primes
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            result = PrintListOfPrimes(startNumber, endNumber);
            Console.WriteLine(string.Join(", ", result ));
        }

        public static List<int> PrintListOfPrimes(int start, int end)
        {
            List<int> result = new List<int>();
            bool isPrime;
            for (int currentNumber = start; currentNumber <= end ; currentNumber++)
            {
                isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (currentNumber == 0 || currentNumber == 1)
                {
                    isPrime = false;
                }
                if (isPrime)
                {
                    result.Add(currentNumber);
                }
            }  
            return result;
        }
    }
}
