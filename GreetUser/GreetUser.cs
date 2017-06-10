namespace MethodsExercises
{
    using System;

    public class GreetUser
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            GreetTheUser(name);
        }
        public static void GreetTheUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
