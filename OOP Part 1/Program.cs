using System;

namespace BankStudentManagementApp
{
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal cancelled.");
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Account Holder: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent to " + HolderName + ".");
        }
    }

    class Program
    {
        static BankAccount acc1 = new BankAccount();
        static BankAccount acc2 = new BankAccount();

        static void Main(string[] args)
        {
            acc1.AccountNumber = 1163;
            acc1.HolderName = "karim";
            acc1.Balance = 120;

            acc2.AccountNumber = 15203;
            acc2.HolderName = "Ali";
            acc2.Balance = 63;

            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("===== Bank & Student Management Menu =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product & Stock Level Check");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Constructor)");
                Console.WriteLine("17. Total Students Counter (Static)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                int choice;
                bool valid = int.TryParse(input, out choice);

                if (!valid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1: Case1_ViewAccountDetails(); break;
                    case 3: Case3_MakeDeposit(); break;
                    case 4: Case4_MakeWithdrawal(); break;
                    case 20:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("This option is not implemented yet.");
                        break;
                }
            }
        }

        static BankAccount SelectAccount()
        {
            Console.WriteLine("1. " + acc1.HolderName);
            Console.WriteLine("2. " + acc2.HolderName);
            Console.Write("Choose account (1 or 2): ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1) return acc1;
            else return acc2;
        }

        static void Case1_ViewAccountDetails()
        {
            BankAccount acc = SelectAccount();
            acc.CheckBalance();
        }

        static void Case3_MakeDeposit()
        {
            BankAccount acc = SelectAccount();
            Console.Write("Enter deposit amount: ");
            double amount;
            double.TryParse(Console.ReadLine(), out amount);
            acc.Deposit(amount);
            Console.WriteLine(acc.HolderName + "'s new balance: " + acc.Balance);
        }

        static void Case4_MakeWithdrawal()
        {
            BankAccount acc = SelectAccount();
            Console.Write("Enter withdrawal amount: ");
            double amount;
            double.TryParse(Console.ReadLine(), out amount);
            acc.Withdraw(amount);
            Console.WriteLine("Updated balance: " + acc.Balance);
        }
    }
}