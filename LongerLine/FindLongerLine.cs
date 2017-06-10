namespace LongerLine
{
    using System;

    public class FindLongerLine
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstLine = CalculateLine(x1, y1, x2, y2);
            var secondLine = CalculateLine(x3, y3, x4, y4);

            if (firstLine >= secondLine)
            {
                var distanceFromFirstPoint = CalcDistance(x1, y1);
                var distanceFromSecondPoint = CalcDistance(x2, y2);
                if (distanceFromFirstPoint <= distanceFromSecondPoint)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                var distanceFromFirstPoint = CalcDistance(x3, y3);
                var distanceFromSecondPoint = CalcDistance(x4, y4);
                if (distanceFromFirstPoint <= distanceFromSecondPoint)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        public static double CalculateLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1) , 2));
        }
        public static double CalcDistance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }

}
