namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 :

            Console.Write("Enter a starting number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("countdown end");

            //task 2 :

            Console.Write("Enter a positive whole number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number2; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum = " + sum);

            //task 3 : 
            Console.Write("Enter a number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number3 + " x " + i + " = " + (number3 * i));
            }

            //task 4 :
            string correctPassword = "Spark2026";
            string input;

            while (true)
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();

                if (input == correctPassword)
                {
                    Console.WriteLine("Access Granted");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }

            //task 5 :
            int secretNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct! It took you " + attempts + " attempts.");
                }

            } while (guess != secretNumber);
        }
    }
}