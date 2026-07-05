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

            //task 4 

            Console.WriteLine("=== Task 4: Subscription End Date ===");
            Console.Write("Enter number of free trial days: ");
            int trialDays = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(trialDays);
            Console.WriteLine("Trial ends on: " + endDate.ToString("yyyy-MM-dd"));
            Console.WriteLine();

            //task 5 

            Console.WriteLine("=== Task 5: Grade Rounding System ===");
            Console.Write("Enter your raw exam score (e.g. 74.6): ");
            double rawScore = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(rawScore, 0);
            Console.WriteLine("Rounded score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            Console.WriteLine();

            //task 6 
            Console.WriteLine("=== Task 6: Password Strength Checker ===");
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool longEnough = password.Length >= 8;
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (longEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Password Strength: Strong");
            }
            else if (!longEnough && containsForbiddenWord)
            {
                Console.WriteLine("Password Strength: Weak (too short AND contains the word 'password')");
            }
            else if (!longEnough)
            {
                Console.WriteLine("Password Strength: Weak (too short)");
            }
            else
            {
                Console.WriteLine("Password Strength: Weak (contains the word 'password')");
            }
            Console.WriteLine();


        }
    }
}
