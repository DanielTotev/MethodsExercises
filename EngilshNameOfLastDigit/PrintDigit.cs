namespace EngilshNameOfLastDigit
{
    using System;

    public class PrintDigit
    {
        public static void Main()
        {
            string numberAsString = Console.ReadLine();
            PrintDigitInEnglish(numberAsString);
        }
        public static void PrintDigitInEnglish(string number)
        {
            int lastDigit = int.Parse(number[number.Length - 1].ToString());

            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;

                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}
