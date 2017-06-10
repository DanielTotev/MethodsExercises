namespace FibbonacciNumbers
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFibonacci(n);
        }
        public static void PrintFibonacci(int n)
        {
            var f0 = 1;
            var f1 = 1;
            for (var i = 0; i < n - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }
    }
}
