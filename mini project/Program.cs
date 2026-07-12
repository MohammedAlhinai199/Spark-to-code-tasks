using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Find Richest Customer");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        FindRichestCustomer();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }

        

        static void AddAccount()
        {
            static void AddAccount()
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new account number: ");
                string accNum = Console.ReadLine();

                if (accountNumbers.Contains(accNum))
                {
                    Console.WriteLine("Error: An account with this number already exists.");
                    return;
                }

                double initialDeposit;
                try
                {
                    Console.Write("Enter initial deposit amount: ");
                    initialDeposit = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                    return;
                }

                if (initialDeposit < 0)
                {
                    Console.WriteLine("Error: Initial deposit cannot be negative.");
                    return;
                }

                customerNames.Add(name);
                accountNumbers.Add(accNum);
                balances.Add(initialDeposit);

                Console.WriteLine($"Account created successfully! Name: {name}, Account Number: {accNum}, Balance: {initialDeposit}");
            }
        }

        static void DepositMoney()
        {
            static void DepositMoney()
            {
                Console.Write("Enter account number: ");
                string accNum = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNum);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                double depositAmount;
                try
                {
                    Console.Write("Enter deposit amount: ");
                    depositAmount = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                    return;
                }

                if (depositAmount <= 0)
                {
                    Console.WriteLine("Error: Deposit amount must be positive.");
                    return;
                }

                balances[index] += depositAmount;

                Console.WriteLine($"Deposit successful. New balance for account {accNum}: {balances[index]}");
            }
        }

        static void WithdrawMoney()
        {
            static void WithdrawMoney()
            {
                Console.Write("Enter account number: ");
                string accNum = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNum);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                double withdrawAmount;
                try
                {
                    Console.Write("Enter withdrawal amount: ");
                    withdrawAmount = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                    return;
                }

                if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Error: Withdrawal amount must be positive.");
                    return;
                }

                if (withdrawAmount > balances[index])
                {
                    Console.WriteLine("Error: Insufficient balance for this withdrawal.");
                    return;
                }

                balances[index] -= withdrawAmount;

                Console.WriteLine($"Withdrawal successful. New balance for account {accNum}: {balances[index]}");
            }
        }

        static void ShowBalance()
        {
            static void ShowBalance()
            {
                Console.Write("Enter account number: ");
                string accNum = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNum);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                Console.WriteLine($"Customer: {customerNames[index]}, Account Number: {accountNumbers[index]}, Balance: {balances[index]}");
            }
        }

        static void TransferAmount()
        {
            static void TransferAmount()
            {
                Console.Write("Enter sender's account number: ");
                string senderAcc = Console.ReadLine();

                Console.Write("Enter receiver's account number: ");
                string receiverAcc = Console.ReadLine();

                int senderIndex = accountNumbers.IndexOf(senderAcc);
                int receiverIndex = accountNumbers.IndexOf(receiverAcc);

                if (senderIndex == -1 || receiverIndex == -1)
                {
                    Console.WriteLine("Error: One or both account numbers do not exist.");
                    return;
                }

                double transferAmount;
                try
                {
                    Console.Write("Enter transfer amount: ");
                    transferAmount = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                    return;
                }

                if (transferAmount <= 0)
                {
                    Console.WriteLine("Error: Transfer amount must be positive.");
                    return;
                }

                if (transferAmount > balances[senderIndex])
                {
                    Console.WriteLine("Error: Insufficient balance for this transfer.");
                    return;
                }

                balances[senderIndex] -= transferAmount;
                balances[receiverIndex] += transferAmount;

                Console.WriteLine($"Transfer successful. {senderAcc} new balance: {balances[senderIndex]}. {receiverAcc} new balance: {balances[receiverIndex]}");
            }
        }

        static void ListAllAccounts()
        {
            static void ListAllAccounts()
            {
                if (customerNames.Count == 0)
                {
                    Console.WriteLine("No accounts exist yet.");
                    return;
                }

                Console.WriteLine("\n--- All Accounts ---");
                for (int i = 0; i < customerNames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Name: {customerNames[i]}, Account Number: {accountNumbers[i]}, Balance: {balances[i]}");
                }
            }
        }

        static void FindRichestCustomer()
        {
            static void FindRichestCustomer()
            {
                if (customerNames.Count == 0)
                {
                    Console.WriteLine("No accounts exist yet.");
                    return;
                }

                int richestIndex = 0;
                for (int i = 1; i < balances.Count; i++)
                {
                    if (balances[i] > balances[richestIndex])
                    {
                        richestIndex = i;
                    }
                }

                Console.WriteLine($"Richest customer: {customerNames[richestIndex]}, Account Number: {accountNumbers[richestIndex]}, Balance: {balances[richestIndex]}");
            }
        }
    }
}