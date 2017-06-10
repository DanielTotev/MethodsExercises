namespace CubeProperties
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();
            var result = CalcParameter(side, parameter);
            Console.WriteLine($"{result:f2}");
        }

        public static double CalcParameter(double side, string parameter)
        {
            var result = 0.0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2));
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (parameter == "area")
            {
                result = 6 * Math.Pow(side, 2);
            }
            return result;
        }
    }
}
