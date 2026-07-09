using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Task1_FixedGradesArray();
            Task2_DynamicToDoList();
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
    }
}