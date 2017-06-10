namespace MasterNumbers
{
    using System;

    public class MasterNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
 
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            bool isSymetric = false;
            string numberAsString = num.ToString();
            for (int i = 0; i < numberAsString.Length / 2; i++)
            {
                if (numberAsString[i] == numberAsString[numberAsString.Length - 1 - i])
                {
                    isSymetric = true;
                }
                else
                {
                    isSymetric = false;
                    break;
                }
            }
            if (numberAsString.Length == 1)
            {
                isSymetric = true;
            }
            return isSymetric;
        }

        public static bool SumOfDigits(int number)
        {
            bool sumCanBeDividedBySeven = false;
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            sumCanBeDividedBySeven = sum % 7 == 0;
            return sumCanBeDividedBySeven;
        }

        public static bool ContainsEvenDigit(int number)
        {
            bool hasEvenDigit = false;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }

                number /= 10;
            }
            return hasEvenDigit;
        }
    }
}
