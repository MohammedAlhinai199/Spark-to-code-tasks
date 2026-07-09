using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Task1_FixedGradesArray();
            Task2_DynamicToDoList();
            Task3_BrowsingHistoryStack();
            Task4_CustomerServiceQueue();
            Task5_ArrayGradeRange();
            Task6_FilteredShoppingList();
            Task7_HighScorePodium();
            Task8_UndoLastAction();
            Task9_GradeAnalyzerWithFunctions();
            Task10_PrintQueueManager();
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

        static void Task7_HighScorePodium()
        {
            List<int> scores = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score #" + (i + 1) + ": ");
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("\n--- Podium ---");
            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);
        }

        static void Task8_UndoLastAction()
        {
            Stack<string> actions = new Stack<string>();

            Console.WriteLine("\nEnter editor actions one by one. Type 'stop' when finished.");
            while (true)
            {
                Console.Write("Action: ");
                string action = Console.ReadLine();

                if (action == "stop")
                {
                    break;
                }

                actions.Push(action);
            }

            Console.WriteLine("\nUndo #1: " + actions.Pop());
            Console.WriteLine("Undo #2: " + actions.Pop());

            Console.WriteLine("\nRemaining actions on the stack:");
            foreach (string action in actions)
            {
                Console.WriteLine("- " + action);
            }
        }

        static void Task9_GradeAnalyzerWithFunctions()
        {
            Console.Write("\nHow many grades do you want to enter? ");
            int count = Convert.ToInt32(Console.ReadLine());

            List<int> grades = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter grade #" + (i + 1) + ": ");
                int grade = Convert.ToInt32(Console.ReadLine());
                grades.Add(grade);
            }

            double average = CalculateAverage(grades);
            int firstFailing = FindFirstFailing(grades);

            Console.WriteLine("\nAverage grade: " + average);

            if (firstFailing == 0)
            {
                Console.WriteLine("No failing grade found (all grades are 60 or above).");
            }
            else
            {
                Console.WriteLine("First failing grade: " + firstFailing);
            }
        }

        static double CalculateAverage(List<int> gradeList)
        {
            int sum = 0;
            for (int i = 0; i < gradeList.Count; i++)
            {
                sum += gradeList[i];
            }
            return (double)sum / gradeList.Count;
        }

        static int FindFirstFailing(List<int> gradeList)
        {
            return gradeList.Find(x => x < 60);
        }

        static void Task10_PrintQueueManager()
        {
            Queue<string> printQueue = new Queue<string>();

            Console.WriteLine("\nEnter print job names one by one. Type 'done' when finished.");
            while (true)
            {
                Console.Write("Job name: ");
                string job = Console.ReadLine();

                if (job == "done")
                {
                    break;
                }

                printQueue.Enqueue(job);
            }

            Console.WriteLine("\nPrint queue BEFORE cancellation:");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }

            Console.Write("\nEnter the name of the job to cancel: ");
            string jobToCancel = Console.ReadLine();

            printQueue = RemoveJob(printQueue, jobToCancel);

            Console.WriteLine("\nPrint queue AFTER cancellation:");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }
        }

        static Queue<string> RemoveJob(Queue<string> jobs, string jobNameToRemove)
        {
            Queue<string> updatedQueue = new Queue<string>();

            while (jobs.Count > 0)
            {
                string currentJob = jobs.Dequeue();
                if (currentJob != jobNameToRemove)
                {
                    updatedQueue.Enqueue(currentJob);
                }
            }

            return updatedQueue;
        }
    }
}