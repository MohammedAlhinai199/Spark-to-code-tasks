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
        }

        // TASK 2 - Square Number Function

        static int Square(int number)
        {
            return number * number;
        }

    }
}