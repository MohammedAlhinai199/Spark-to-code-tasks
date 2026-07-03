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

            
        }
    }
}
