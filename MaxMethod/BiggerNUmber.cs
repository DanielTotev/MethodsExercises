namespace MaxMethod
{
    using System;
    public class BiggerNumber
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int biggerNumber = GetBiggerNumber(firstNum, secondNum);
            int biggestNumber = GetBiggerNumber(biggerNumber, thirdNumber);
            Console.WriteLine(biggestNumber);
        }
        public static int GetBiggerNumber(int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
