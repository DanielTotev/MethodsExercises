namespace Factorial
{
    using System;
    using System.Numerics;
    public class CalculateFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = CalcFactorial(n);
            Console.WriteLine(CalculateFactorialZeros(result));
        }
        public static BigInteger CalcFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static int CalculateFactorialZeros(BigInteger factorial)
        {
            
            int count = 0;
            for (int i = 0; i < factorial.ToString().Length; i++)
            {
                if (factorial % 10 == 0)
                {
                    count++;
                    factorial /= 10;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
