using System;
using System.CodeDom;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Program
    {   // List to store tasks
        static List<string> tasks = new List<string>();
        static void Main(string[] args) //Main Method :- Entry Point of the Progress
        {
            //Main loop for the inventory management syatem
            while (true)
            {
                //Display main options
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1, Add Item");
                Console.WriteLine("2, Remove Item");
                Console.WriteLine("3, View Inventory");
                Console.WriteLine("4, Exit");

                //Prompt user for choice
                Console.Write("Enter your Choice: ");
                int choice;
                if(!int.TryParse(Console.ReadLine(), out choice)) //parse user input
                {
                    Console.WriteLine("Invalid choice. Please Enter a Number");
                    continue;
                }

                //switch statement to handle user choice
                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        ViewInventory();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }

        //method to add task
        static void AddTask()
        {
            Console.Write("Enter task description: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }
        //method to remove task
        static void RemoveItem()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            Console.Write("Enter the task number to mark as completed: ");
            int taskNumber;
            if (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed.");
            tasks.RemoveAt(taskNumber - 1);
        }

        //method to view tasks
        static void ViewInventory()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}
