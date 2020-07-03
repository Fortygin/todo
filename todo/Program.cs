using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    class Program
    {
        static List<string> GetUniqueElements(List<string> list)
        {
            int i = 0;
            List<string> distinctElements = new List<string>();
            while (i < list.Count)
            {
                if (!distinctElements.Contains(list[i]))
                    distinctElements.Add(list[i]);

                i++;

            }

            distinctElements.RemoveAll(x => x.Count() == 0);

            Console.WriteLine();
            
            return distinctElements;
        }


        static List<string> RemoveElement(List<string> list, int a)
        {
            List<string> removeElements = new List<string>();

            int j = 0;
            while (j < list.Count)
            {
                if (!removeElements.Contains(list[j]))
                    removeElements.Add(list[j]);
                j++;
            }
            int b = a - 1;
            removeElements.Remove(removeElements[b]);


            return removeElements;
        }
        static void ListOutput(List<string> list)
        {
            Console.WriteLine("\t Task List");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(i + 1 + " " + list[i]);

        }

        static string userName (string username)
        {
            while (true)
            {
                Console.WriteLine("What's your name?");
                username = Console.ReadLine();
                bool bisEmpty = String.IsNullOrWhiteSpace(username);

                if (bisEmpty)
                {
                    Console.WriteLine("Enter your Name, please");
                    Console.ReadKey();
                }
                else
                    break;

            }

            return username;
        }

        static void Main(string[] args)
        {
            string username = String.Empty;

            Console.WriteLine("Hello, " + userName(username));

            string input = String.Empty;
            List<string> tasks = new List<string>();
     
            while (true)
            {
                Console.WriteLine("Сhoose a number with the action you want to do:\n1 - ADD task\n2 - Delete task\n3 - show all tasks\n4 - Exit the program");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    Console.WriteLine("Now you will enter new tasks");

                    string input2 = input;
                    Console.WriteLine("Enter new task");
                    input2 = Console.ReadLine().Trim();
                    tasks.Add(input2);
                    GetUniqueElements(tasks);

                }
                else if (action == "2")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Your list is empty! Add task\nPress any key to continue");

                        Console.ReadKey();

                        continue;
                    }
                    ListOutput(GetUniqueElements(tasks));
                    Console.WriteLine("DELETE task");
                    Console.WriteLine("enter the number of the task to be deleted");
                    int c = Convert.ToInt32(Console.ReadLine());
                    tasks = RemoveElement(tasks, c);
                  
                    ListOutput(tasks);
                }
                else if (action =="3")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Your list is empty! Add task\nPress any key to continue");

                        Console.ReadKey();

                       continue;
                    }
                    ListOutput(GetUniqueElements(tasks));
                }
                else if (action== "4")
                {
                    Console.WriteLine("Bye bye");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter number, please\nPress any key to continue");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
