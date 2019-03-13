using System;


namespace FinalApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //TDA - ToDoApp
            TDA theTda = new TDA();
            List<Todo> theList = theTda.list();
            string userInput = "";
            string id;
            string yesNo;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~To Do App~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

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
                    if (yesNo == "yes" || "y")
                    {
                        Console.WriteLine("Enter the id of the task you would like to remove.");
                        id = Console.ReadLine();
                        Todo removeItem = theTda.GetToDo(id);
                        theTda.remove(removeItem);
                        theTda.save();

                        Console.WriteLine("Tast deleted");

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
                    if (yesNo == "yes" || "y")
                    {
                        Console.WriteLine("Please enter id of the task you wish to masrk as complete...");
                        id = Console.ReadLine();
                        Todo markAsDone = theTda.GetTodo(id);
                        markAsDone.Status = true;
                        theTda.save();

                    }
                    else
                    {
                        Console.WriteLine("Back to menu...")
                    }
                }
                else if (userInput == "list completed")
                {
                    foreach (Todo item in theTda.listCompleted())
                    {
                        Console.WriteLine(item)
                    }
                }
                else if (userInput == "exit")
                {
                    break
                }
                else
                {
                    Console.WriteLine("This is invalid input please try again.");
                }
            }

        }
    }
    public class Todo
    {
        public int Id { get; set; }
    }
}
