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
            List<string> RemoveElements = new List<string>();

            int j = 0;
            while (j < list.Count)
            {
                if (!RemoveElements.Contains(list[j]))
                    RemoveElements.Add(list[j]);
                j++;
            }
            RemoveElements.RemoveAt(a - 1);

            return RemoveElements;
        }
        static void ListOutput(List<string> list)
        {
            Console.WriteLine("\t Task List");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(i + 1 + " " + list[i].Trim());

        }

     

        static void Main(string[] args)
        {
            string username = null;

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


            Console.WriteLine("Hello, " + username);

            string input = null;
            List<string> tasks = new List<string>();

            while (true)
            {

                Console.WriteLine("Сhoose a number with the action you want to do:\n1 - ADD task\n2 - Delete task\n3 - show all tasks\n4 - Exit the program");
                string action = Console.ReadLine();

                switch (action)
                {

                    case "1":


                        Console.WriteLine("Now you will enter new tasks");

                        string input2 = input;
                        Console.WriteLine("Enter new task");
                        input2 = Console.ReadLine();
                        tasks.Add(input2);

                        
                        GetUniqueElements(tasks);

                        break;

                    case "2":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Your list is empty! Add task\nPress any key to continue");

                            Console.ReadKey();

                            break;
                            
                        }
                        while (true)
                        {
                            ListOutput(GetUniqueElements(tasks));
                            Console.WriteLine("DELETE task");
                            Console.WriteLine("enter the number of the task to be deleted");

                            try
                            {
                                int c = Convert.ToInt32(Console.ReadLine());
                                RemoveElement(tasks, c);
                                ListOutput(RemoveElement(tasks, c));
                                break;
                            }

                            catch
                            {
                                Console.WriteLine("Enter number, please\nPress any key to continue");
                                Console.ReadLine();
                                continue;
                            }
                        }

                        break;

                    case "3":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Your list is empty! Add task\nPress any key to continue");

                            Console.ReadKey();

                            break;
                        }

                        ListOutput(GetUniqueElements(tasks));

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Do you want to DELTED a task?");
                                Console.WriteLine("1 - YES\n2 - NO");
                                int num = Int32.Parse(Console.ReadLine());
                                if (num == 1)
                                {
                                    goto case "2";
                                }

                                else
                                {
                                    Console.WriteLine("Want to add a task - PRESS 1\nSee the whole list - PRESS 2\nExit the program - PRESS 3");
                                    int num3 = Int32.Parse(Console.ReadLine());

                                    if (num3 == 1)
                                    {
                                        goto case "1";

                                    }
                                    else if (num3 == 2)
                                    {
                                        goto case "3";
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bye bye");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }



                                }
                                break;
                            }

                            catch
                            {
                                Console.WriteLine("Enter number, please\nPress any key to continue");
                                Console.ReadLine();
                                continue;
                            }

                        }

                        break;
                    case "4":

                        Console.WriteLine("Bye bye");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;




                    default:
                        Console.WriteLine("Unknown action! Choose a number with the action");
                        Console.ReadKey();
                        continue;


                }

            }





        }
    }
}
