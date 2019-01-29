using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            string name = "";
            int age = 0;
            int year = 0;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello! Your name is {0} and You are {1} years old. You were born in {2}.", name, age, year - age);
        }
    }
}

