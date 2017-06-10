namespace CenterPoint
{
    using System;

    public class Points
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointDistance = CalcDistance(x1, y1);
            double secondPointDistance = CalcDistance(x2, y2);
            if (firstPointDistance < secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
     
            }
        }

        public static double CalcDistance(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2);
        }
    }
}
