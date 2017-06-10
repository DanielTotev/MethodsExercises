namespace NumbersInReversedOrder
{
    using System;

    public class ReversedNumbers
    {
        public static void Main()
        {
            string floatingPointAsString = Console.ReadLine();
            ReverseFloatingPoints(floatingPointAsString);
        }
        public static void ReverseFloatingPoints(string number)
        {
            string result = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            Console.WriteLine(result);
        }
    }
}
