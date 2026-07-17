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

    class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Registration confirmation email sent for " + Name + ".");
        }
    }

    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock available.");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged for " + ProductName + ".");
        }
    }

    class Program
    {
        static BankAccount acc1 = new BankAccount();
        static BankAccount acc2 = new BankAccount();
        static Student std1 = new Student();
        static Student std2 = new Student();
        static Product prod1 = new Product();
        static Product prod2 = new Product();

        static void Main(string[] args)
        {
            acc1.AccountNumber = 1163;
            acc1.HolderName = "karim";
            acc1.Balance = 120;

            acc2.AccountNumber = 15203;
            acc2.HolderName = "Ali";
            acc2.Balance = 63;

            std1.Name = "Ali";
            std1.Address = "Muscat";
            std1.Grade = 65;

            std2.Name = "Ahmed";
            std2.Address = "Muscat";
            std2.Grade = 70;

            prod1.ProductName = "Wireless Mouse";
            prod1.Price = 5.500;
            prod1.StockQuantity = 50;

            prod2.ProductName = "Mechanical Keyboard";
            prod2.Price = 15.750;
            prod2.StockQuantity = 20;

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
                    case 2: Case2_UpdateStudentAddress(); break;
                    case 3: Case3_MakeDeposit(); break;
                    case 4: Case4_MakeWithdrawal(); break;
                    case 5: Case5_ViewProductDetails(); break;
                    case 6: Case6_RegisterStudent(); break;
                    case 7: Case7_CompareBalances(); break;
                    case 8: Case8_RestockAndCheck(); break;
                    case 9: Case9_TransferBetweenAccounts(); break;
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

        static Student SelectStudent()
        {
            Console.WriteLine("1. " + std1.Name);
            Console.WriteLine("2. " + std2.Name);
            Console.Write("Choose student (1 or 2): ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1) return std1;
            else return std2;
        }

        static Product SelectProduct()
        {
            Console.WriteLine("1. " + prod1.ProductName);
            Console.WriteLine("2. " + prod2.ProductName);
            Console.Write("Choose product (1 or 2): ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1) return prod1;
            else return prod2;
        }

        static void Case1_ViewAccountDetails()
        {
            BankAccount acc = SelectAccount();
            acc.CheckBalance();
        }

        static void Case2_UpdateStudentAddress()
        {
            Student s = SelectStudent();
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            s.Address = newAddress;
            Console.WriteLine("Address updated to: " + s.Address);
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

        static void Case5_ViewProductDetails()
        {
            Product p = SelectProduct();
            double value = p.GetInventoryValue();
            Console.WriteLine("Total Inventory Value: " + value);
        }

        static void Case6_RegisterStudent()
        {
            Student s = SelectStudent();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            s.Register(email);
            Console.WriteLine(s.Name + " has been registered successfully.");
        }

        static void Case7_CompareBalances()
        {
            if (acc1.Balance > acc2.Balance)
            {
                Console.WriteLine(acc1.HolderName + " has more money.");
            }
            else if (acc2.Balance > acc1.Balance)
            {
                Console.WriteLine(acc2.HolderName + " has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have equal balances.");
            }
        }

        static void Case8_RestockAndCheck()
        {
            Product p = SelectProduct();
            Console.Write("Enter quantity to restock: ");
            int qty;
            int.TryParse(Console.ReadLine(), out qty);
            p.Restock(qty);

            if (p.StockQuantity < 10)
            {
                Console.WriteLine("Stock Level: Low");
            }
            else if (p.StockQuantity <= 49)
            {
                Console.WriteLine("Stock Level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock Level: Well Stocked");
            }
        }

        static void Case9_TransferBetweenAccounts()
        {
            Console.WriteLine("Select source account:");
            BankAccount source = SelectAccount();
            Console.WriteLine("Select destination account:");
            BankAccount destination = SelectAccount();
            Console.Write("Enter transfer amount: ");
            double amount;
            double.TryParse(Console.ReadLine(), out amount);

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine("Transfer successful.");
            }
            else
            {
                Console.WriteLine("Transfer failed: insufficient funds in source account.");
            }
        }
    }
}