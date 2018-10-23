using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captstone2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> Tasks = new List<Task>();
            bool loop = true;
            while (loop)
            {

                Console.WriteLine("Welcome to the Task Manager. Please select a task");
                Console.WriteLine("1.List Task");
                Console.WriteLine("2.Add Task");
                Console.WriteLine("3.Delete A Task");
                Console.WriteLine("4.Mark Task Complete");
                Console.WriteLine("5.Quit");
                string choice;
                choice = Console.ReadLine();
                Console.WriteLine();


                if (choice == "1")
                {
                    foreach (Task x in Tasks)
                    {
                        Console.WriteLine("Completion status: " + x.completed);
                        Console.WriteLine("Due Date: " + x.dueDate);
                        Console.WriteLine("Member Name: " + x.memberName);
                        Console.WriteLine("Description: " + x.briefDescrip);
                        Console.WriteLine("----------------------------");
                    }
                    

                }
                else if (choice == "2")
                {
                    string name, descrip, date;
                    Console.WriteLine("Please enter Name, Description, and Due Date");
                    Console.Write("Name: "); name = Console.ReadLine();
                    Console.Write("Description: "); descrip = Console.ReadLine();
                    Console.Write("Due Date: "); date = Console.ReadLine();
                    Tasks.Add(new Task(name, descrip, date, false));
                    
                }

                else if (choice == "3")
                {
                    Console.WriteLine("Which task do you wish to delete?");
                    int i = 1;
                    foreach (Task x in Tasks)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("Completion status: " + x.completed);
                        Console.WriteLine("Due Date: " + x.dueDate);
                        Console.WriteLine("Member Name: " + x.memberName);
                        Console.WriteLine("Description: " + x.briefDescrip);
                        i++;
                    }
                    int userInput = int.Parse(Console.ReadLine());
                    Tasks.RemoveAt(userInput - 1);
                    
                }

                else if (choice == "4")

                {
                    Console.WriteLine("Which task do you wish to mark as complete?");
                    int i = 1;
                    foreach (Task x in Tasks)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("Completion status: " + x.completed);
                        Console.WriteLine("Due Date: " + x.dueDate);
                        Console.WriteLine("Member Name: " + x.memberName);
                        Console.WriteLine("Description: " + x.briefDescrip);
                        i++;
                    }
                    int userInput = int.Parse(Console.ReadLine());
                    Tasks[userInput - 1].completed = true;
                   
                    
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                    Console.WriteLine("----------------------------");
                }
                Console.ReadLine();

                }
            


        }
    }
}

