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

            //task 6 :
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid whole numbers.");
            }

            //task 7 :
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine();
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Time-of-day Greeting");
                Console.WriteLine("3) Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Good day to you!");
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose 1, 2, or 3.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a number (1, 2, or 3).");
                }
            }

            //task 8 : 
            Console.Write("Enter a positive whole number: ");
            int n8 = Convert.ToInt32(Console.ReadLine());

            int sumEven = 0;

            for (int i = 1; i <= n8; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = sumEven + i;
                }
            }

            Console.WriteLine("Sum of even numbers = " + sumEven);

            //task 9 :
            int n9 = 0;
            bool validInput = false;

            do
            {
                try
                {
                    Console.Write("Enter a positive whole number: ");
                    n9 = Convert.ToInt32(Console.ReadLine());

                    if (n9 <= 0)
                    {
                        Console.WriteLine("Number must be positive, try again.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid whole number, try again.");
                }

            } while (!validInput);

            int sum9 = 0;

            for (int i = 1; i <= n9; i++)
            {
                sum9 = sum9 + i;
            }

            Console.WriteLine("Sum from 1 to " + n9 + " = " + sum9);


            //task 10 :
            string correctPin = "1234";
            double balance = 100.000;
            bool pinCorrect = false;
            int pinAttempts = 0;

            while (pinAttempts < 3 && pinCorrect == false)
            {
                try
                {
                    Console.Write("Enter your 4-digit PIN: ");
                    string enteredPin = Console.ReadLine();

                    if (enteredPin == correctPin)
                    {
                        pinCorrect = true;
                    }
                    else
                    {
                        pinAttempts = pinAttempts + 1;
                        Console.WriteLine("Wrong PIN. Attempts left: " + (3 - pinAttempts));
                    }
                }
                catch (FormatException)
                {
                    pinAttempts = pinAttempts + 1;
                    Console.WriteLine("Invalid entry. Attempts left: " + (3 - pinAttempts));
                }
            }

            if (pinCorrect == false)
            {
                Console.WriteLine("Card Blocked");
            }
            else
            {
                int atmChoice = 0;

                while (atmChoice != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Check Balance");
                    Console.WriteLine("4) Exit");
                    Console.Write("Choose an option: ");

                    try
                    {
                        atmChoice = Convert.ToInt32(Console.ReadLine());

                        switch (atmChoice)
                        {
                            case 1:
                                try
                                {
                                    Console.Write("Enter deposit amount: ");
                                    double depositAmount = Convert.ToDouble(Console.ReadLine());

                                    if (depositAmount <= 0)
                                    {
                                        Console.WriteLine("Deposit amount must be positive.");
                                    }
                                    else
                                    {
                                        balance = balance + depositAmount;
                                        Console.WriteLine("Deposit successful. New balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case 2:
                                try
                                {
                                    Console.Write("Enter withdrawal amount: ");
                                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                                    if (withdrawAmount <= 0)
                                    {
                                        Console.WriteLine("Withdrawal amount must be positive.");
                                    }
                                    else if (withdrawAmount > balance)
                                    {
                                        Console.WriteLine("Insufficient balance.");
                                    }
                                    else
                                    {
                                        balance = balance - withdrawAmount;
                                        Console.WriteLine("Withdrawal successful. New balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Current balance: " + balance + " OMR");
                                break;

                            case 4:
                                Console.WriteLine("Thank you for using the ATM. Goodbye!");
                                break;

                            default:
                                Console.WriteLine("Invalid option, please choose 1-4.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number for your choice.");
                    }
                }
            }


        }
    }
}