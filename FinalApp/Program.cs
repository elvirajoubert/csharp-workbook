using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace FinalApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            DbContextOptionsBuilder<FinalAppDBContext> builder = new DbContextOptionsBuilder<FinalAppDBContext>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoDb;Trusted_Connection=True;");
            DbContextOptions<FinalAppDBContext> opts = builder.Options;
            FinalAppDBContext context = new FinalAppDBContext(opts);







            //TDA - ToDoApp
            TDA theTda = new TDA(context);
            List<Todo> theList = theTda.List();
            string userInput = "";
            string id;
            string yesNo;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~To Do App~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");

            while (userInput != "exit")
            {
                Console.WriteLine("Please enter 'add', 'remove', 'list','update', 'list completed','display id' or 'exit'");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    Console.WriteLine("Do you want to add a task?");
                    yesNo = Console.ReadLine();

                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter a task:");
                        string task = Console.ReadLine();
                        theTda.Add(task);
                        theTda.Save();
                    }
                    else
                    {
                        Console.WriteLine("Returning to menu...");
                    }
                }
                else if (userInput == "list")
                {
                    var list = theTda.List();
                    foreach (Todo item in list)
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
                        Todo removeItem = theTda.Find(id);
                        theTda.RemoveTodo(removeItem);
                        //theTda.Save();

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
                        Console.WriteLine("Please enter id of the task you wish to mark as complete...");
                        id = Console.ReadLine();
                        Todo markAsDone = theTda.Find(id);
                        markAsDone.Status = true;
                        theTda.Save();
                        Console.ReadLine();

                    }


                    else
                    {
                        Console.WriteLine("Back to menu...");
                    }
                }
                else if (userInput == "list completed")
                {
                    var complete = theTda.ListCompleted();
                    foreach (Todo item in complete)
                    {
                        Console.WriteLine(item);

                    }
                }



                else if (userInput == "display id")
                {
                    var newList = theTda.List();
                    foreach (Todo item in newList)
                    {
                        Console.WriteLine("Please enter id of the task you wish to display...");
                        id = Console.ReadLine();
                        Todo displayTodo = theTda.Find(id);
                        //theTda.Save();
                        Console.WriteLine(displayTodo);
                        break;

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
            public FinalAppDBContext context;

            public TDA(FinalAppDBContext context)
            {
                this.context = context;
                context.Database.EnsureCreated();
            }

            public List<Todo> List()
            {
                List<Todo> allItems = new List<Todo>();

                foreach (Todo item in context.Todos)
                {
                    allItems.Add(item);
                }
                return allItems;
            }

            //adding items to database

            public void Add(string task)
            {
                context.Todos.Add(new Todo(task));
            }

            //searching an item by id

            public Todo Find(string findId)
            {

                //Todo foundToDo = new Todo(string findId);



                foreach (Todo item in context.Todos)
                {
                    if (item.Id.ToString() == findId)
                    {
                        return item;
                        //Console.WriteLine("{0} {1}", foundToDo.Id, foundToDo.Task);

                    }



                }
                return null;

            }

            public List<Todo> ListCompleted()
            {
                List<Todo> completedList = new List<Todo>();

                foreach (Todo item in context.Todos)
                {
                    if (item.Status == true)
                    {
                        completedList.Add(item);

                    }
                }
                return completedList;

            }


            public void RemoveTodo(Todo removeTask)
            {
                context.Todos.Remove(removeTask);
                context.SaveChanges();
            }

            public void Save()
            {
                context.SaveChanges();
            }


        }
    }
}

