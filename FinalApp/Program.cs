using System;
using System.Collections.Generic;


namespace FinalApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //TDA - ToDoApp
            TDA theTda = new TDA();
            List<Todo> theList = theTda.list();
            string userInput = "";
            string id;
            string yesNo;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~To Do App~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");

            while (userInput != "exit")
            {
                Console.WriteLine("Please enter 'add', 'remove', 'list','update' 'list completed' or 'exit'");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    Console.WriteLine("Do you want to add a task?");
                    yesNo = Console.ReadLine();

                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter a task:");
                        string task = Console.ReadLine();
                        theTda.add(task);
                        theTda.save();
                    }
                    else
                    {
                        Console.WriteLine("Returning to menu...");
                    }
                }
                else if (userInput == "list")
                {
                    foreach (Todo item in theTda.list())
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (userInput == "remove")
                {
                    Console.WriteLine("Would you like to delete a task? (Y/N)");
                    yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter the id of the task you would like to remove.");
                        id = Console.ReadLine();
                        Todo removeItem = theTda.GetTodo(id);
                        theTda.remove(removeItem);
                        theTda.save();

                        Console.WriteLine("Task deleted");
                    }
                    else
                    {
                        Console.WriteLine("Back to menu...");
                    }
                }
                else if (userInput == "update")
                {
                    Console.WriteLine("Would you like to mark the task as complete?(Y/N)");
                    yesNo = Console.ReadLine().ToLower();

                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Please enter id of the task you wish to masrk as complete...");
                        id = Console.ReadLine();
                        Todo markAsDone = theTda.GetTodo(id);
                        markAsDone.Status = true;
                        theTda.save();
                    }
                    else
                    {
                        Console.WriteLine("Back to menu...");
                    }
                }
                else if (userInput == "list completed")
                {
                    foreach (Todo item in theTda.ListCompleted())
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (userInput == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This is an invalid input, please try again.");
                }
            }
        }

        public class Todo
        {
            public int Id { get; set; }
            public string Task { get; set; }
            public bool Status { get; set; }

            public Todo(int Id, string Task)
            {
                this.Id = Id;
                this.Task = Task;
            }

            public Todo(string Task)
            {
                this.Task = Task;
            }

            public override string ToString()
            {
                return Id + ": " + Task + " | " + (Status ? "Complete" : "Incomplete");
            }
        }

        public class TDA
        {
            public Context context;

            public TDA()
            {
                context = new Context();
                context.Database.EnsureCreated();
            }

            public List<Todo> list()
            {
                List<Todo> allItems = new List<Todo>();
                foreach (Todo item in context.myList)
                {
                    allItems.Add(item);
                }
                return allItems;
            }

            //adding items to database

            public void add(string task)
            {
                context.MyList.Add(new Todo(task));
            }

            //searching an item by id

            public Todo GetTodo(string findId)
            {
                foreach (Todo item in context.myList)
                {
                    if (item.Id.ToString() == findId)
                    {
                        return item;
                    }
                }
                return null;
            }

            public List<Todo> ListCompleted()
            {
                List<Todo> completedList = new List<Todo>();

                foreach (Todo item in context.myList)
                {
                    if (item.Status == true)
                    {
                        completedList.Add(item);
                        return completedList;
                    }
                }
                return null;
            }

            public void remove(Todo removeItem)
            {
                context.myListRemove(removeItem);
            }

            public void save()
            {
                context.SaveChanges();
            }
        }
    }
}