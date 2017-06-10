namespace GeometyCalculator
{
    using System;

    public class Calculator
    {
        public static void Main()
        {
            string figure = Console.ReadLine().ToLower();
            double result = CalculatePerimeter(figure);
            Console.WriteLine($"{result:f2}");
        }

        public static double CalculatePerimeter(string figure)
        {
            double result = 0.0;
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2.0;
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side * side;
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = width * height;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(radius, 2);
            }
            return result;
        }
    }
}
