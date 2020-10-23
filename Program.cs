using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Exercise 1--------
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles


            Console.Write("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.Write($"Hello, {userName}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.Write($"{color} is an awsome color, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.Write($"I absolutley love that animal, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile")

            Console.WriteLine("---------------------------------------")


            Console.WriteLine($"Name: {userName}")
            Console.WriteLine($"Favorite Color: {color}")
            Console.WriteLine($"Favorite Animal: {animal}")
            Console.WriteLine($"Favorite Band: {band}")
        }
    }
}
