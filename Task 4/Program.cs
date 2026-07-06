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
    }
}