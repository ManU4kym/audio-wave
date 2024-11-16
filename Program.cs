using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string input;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("            To-Do List             ");
            Console.WriteLine("====================================");
            Console.ResetColor();
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Remove task");
            Console.WriteLine("3. View tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    RemoveTask(tasks);
                    break;
                case "3":
                    ViewTasks(tasks);
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Exiting To-Do List. Goodbye!");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ResetColor();
                    break;
            }
            if (input != "4")
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        } while (input != "4");
    }

    static void AddTask(List<string> tasks)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Task '{task}' added successfully!");
        Console.ResetColor();
    }

    static void RemoveTask(List<string> tasks)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter task to remove: ");
        string taskToRemove = Console.ReadLine();
        if (tasks.Contains(taskToRemove))
        {
            tasks.Remove(taskToRemove);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Task '{taskToRemove}' removed successfully!");
        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task not found.");
        }
        Console.ResetColor();
    }

    static void ViewTasks(List<string> tasks)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nCurrent Tasks:");
        Console.ResetColor();
        if (tasks.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No tasks available.");
            Console.ResetColor();
        }
        else
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
}
