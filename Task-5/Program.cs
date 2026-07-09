using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Session 5 Practice Tasks ===");

            Task1_FixedGradesArray();
            Task2_DynamicToDoList();
            Task3_BrowsingHistoryStack();
            Task4_CustomerServiceQueue();
            Task5_ArrayGradeRange();
            Task6_FilteredShoppingList();
        }

        static void Task1_FixedGradesArray()
        {
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade #" + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nHere are the grades you entered:");
            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }
        }

        static void Task2_DynamicToDoList()
        {
            List<string> toDoList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task #" + (i + 1) + ": ");
                string task = Console.ReadLine();
                toDoList.Add(task);
            }

            Console.WriteLine("\nYour To-Do List:");
            int number = 1;
            foreach (string task in toDoList)
            {
                Console.WriteLine(number + ". " + task);
                number++;
            }
        }

        static void Task3_BrowsingHistoryStack()
        {
            Stack<string> history = new Stack<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL #" + (i + 1) + ": ");
                string url = Console.ReadLine();
                history.Push(url);
            }

            string previousPage = history.Pop();
            Console.WriteLine("\nYou pressed 'back'. You landed on: " + previousPage);
        }

        static void Task4_CustomerServiceQueue()
        {
            Queue<string> customerQueue = new Queue<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name #" + (i + 1) + ": ");
                string name = Console.ReadLine();
                customerQueue.Enqueue(name);
            }

            string servedCustomer = customerQueue.Dequeue();
            Console.WriteLine("\nNow serving: " + servedCustomer);
        }

        static void Task5_ArrayGradeRange()
        {
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade #" + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(grades);

            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Length;

            Console.WriteLine("\nLowest grade: " + grades[0]);
            Console.WriteLine("Highest grade: " + grades[grades.Length - 1]);
            Console.WriteLine("Average grade: " + average);
        }

        static void Task6_FilteredShoppingList()
        {
            List<string> shoppingList = new List<string>();

            Console.WriteLine("\nEnter shopping items one by one. Type 'done' when finished.");
            while (true)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();

                if (item == "done")
                {
                    break;
                }

                shoppingList.Add(item);
            }

            Console.WriteLine("\nShopping list BEFORE removal:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }

            Console.Write("\nEnter the item you want to remove: ");
            string itemToRemove = Console.ReadLine();
            shoppingList.Remove(itemToRemove);

            Console.WriteLine("\nShopping list AFTER removal:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}