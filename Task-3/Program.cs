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

        }
    }
}
