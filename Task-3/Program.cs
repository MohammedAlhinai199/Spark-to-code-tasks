using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task 1  
            Console.WriteLine("=== Task 1: Absolute Difference ===");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);
            Console.WriteLine("The absolute difference is: " + difference);
            Console.WriteLine();


            //Task 2 

            Console.WriteLine("=== Task 2: Power & Root Explorer ===");
            Console.Write("Enter a number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(baseNum, 2);
            double squareRoot = Math.Sqrt(baseNum);
            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);
            Console.WriteLine();

            //task 3 

            Console.WriteLine("=== Task 3: Name Formatter ===");
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Uppercase: " + fullName.ToUpper());
            Console.WriteLine("Lowercase: " + fullName.ToLower());
            Console.WriteLine("Character count: " + fullName.Length);
            Console.WriteLine();
        }
    }
}
