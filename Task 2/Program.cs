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
        }
    }
}
