namespace Task_4
{
    internal class Program
    {
        // TASK 1 - Personalized Welcome Function
        // void return type, one string parameter
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "! We're glad you're here.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Task 1: Personalized Welcome =====");
            Console.Write("Enter your name: ");
            string t1Name = Console.ReadLine();
            PrintWelcome(t1Name);
            Console.WriteLine("===== Task 2: Square Number =====");
            Console.Write("Enter a number to square: ");
            int t2Number = Convert.ToInt32(Console.ReadLine());
            int t2Result = Square(t2Number);
            Console.WriteLine("The square of " + t2Number + " is " + t2Result);
            Console.WriteLine("===== Task 3: Celsius to Fahrenheit =====");
            Console.Write("Enter a temperature in Celsius: ");
            double t3Celsius = Convert.ToDouble(Console.ReadLine());
            double t3Fahrenheit = CelsiusToFahrenheit(t3Celsius);
            Console.WriteLine(t3Celsius + " C is equal to " + t3Fahrenheit + " F");
            Console.WriteLine("===== Task 4: Fixed Menu Display =====");
            DisplayMenu();
            Console.WriteLine("===== Task 5: Even or Odd =====");
            Console.Write("Enter a number: ");
            int t5Number = Convert.ToInt32(Console.ReadLine());
            bool t5IsEven = IsEven(t5Number);
            if (t5IsEven)
            {
                Console.WriteLine(t5Number + " is Even");
            }
            else
            {
                Console.WriteLine(t5Number + " is Odd");
            }
            Console.WriteLine("===== Task 6: Rectangle Area & Perimeter =====");
            Console.Write("Enter the length of the rectangle: ");
            double t6Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double t6Width = Convert.ToDouble(Console.ReadLine());
            double t6Area = CalculateRectangleArea(t6Length, t6Width);
            double t6Perimeter = CalculatePerimeter(t6Length, t6Width);
            Console.WriteLine("Area: " + t6Area);
            Console.WriteLine("Perimeter: " + t6Perimeter);
            Console.WriteLine("===== Task 7: Grade Letter =====");
            Console.Write("Enter a score (0-100): ");
            int t7Score = Convert.ToInt32(Console.ReadLine());
            string t7Grade = GetGradeLetter(t7Score);
            Console.WriteLine("Score " + t7Score + " corresponds to grade: " + t7Grade);
            Console.WriteLine("===== Task 8: Countdown =====");
            Console.Write("Enter a starting number for the countdown: ");
            int t8Start = Convert.ToInt32(Console.ReadLine());
            Countdown(t8Start);
        }

        // TASK 2 - Square Number Function

        static int Square(int number)
        {
            return number * number;
        }

        // TASK 3 - Celsius to Fahrenheit Function
        
       
        static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        // TASK 4 - Fixed Menu Display Function
       
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        // TASK 5 - Even or Odd Function
        
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // TASK 6 - Rectangle Area & Perimeter Functions
        
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        // TASK 7 - Grade Letter Function
 
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

            // TASK 8 - Countdown Function
            
            static void Countdown(int start)
            {
                for (int i = start; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}