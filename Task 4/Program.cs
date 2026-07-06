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
        }
    }
}