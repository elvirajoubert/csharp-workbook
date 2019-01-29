using System;
using System.Threading;

namespace textgame2
{
    class Program
    {
       static void Main(string[] args)
        
        {
            int stick = 0;
            // Random fdmg1 = new Random();
            // Random edmg1 = new Random();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(2000);

            Console.WriteLine ("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            string choice1 = Console.ReadLine();
            Console.WriteLine("You chose {0}.",choice1);
            //first IF statement
            if (choice1 =="y"|| choice1 == "Y"|| choice1 =="Yes"|| choice1 == "YES"|| choice1 =="yes")
            {
            Thread.Sleep(2000);
            stick = 1;
            Console.WriteLine("You took the stick");
            }
            else
            {
             Console.WriteLine("You did not take the stick");
            Thread.Sleep(2000);
            stick = 0;
           //second IF statement
            }
         Console.WriteLine("As you proceed further into the cave, you will see a small glowing object ");
         Console.WriteLine("Do you approach the object? [y/n]: ");
         string choice2 = Console.ReadLine();
         stick = 2;
         Console.WriteLine("You approach the object...", choice2);
         if (choice2 == "y" || choice2 =="Y" || choice2 =="Yes" ||choice2 =="YES" ||choice2 =="yes")
         {
            Thread.Sleep(2000);
            Console.WriteLine("You aproach the object...");
            Thread.Sleep(2000);
            
            Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
            Console.WriteLine("The eye belongs to a giant spider!");

          Console.WriteLine("Do you take try to fight it? [y/n]: ");
            string choice3 = Console.ReadLine();
            stick = 0;
            Console.WriteLine("You only have a stick to fight with!", choice3);
            if (choice3 == "y" || choice3 =="Y" || choice3 =="Yes" ||choice3 =="YES" ||choice2 =="yes")
         {
            Thread.Sleep(2000);
            Console.WriteLine("You quickly jab the spider in its eye and gain an advantage");
            Thread.Sleep(2000);
            Console.WriteLine("Fighting...");
            Console.WriteLine("YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER");
            Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
            Thread.Sleep(2000);
            // Random outcome = new Random();
            //         Console.WriteLine($"You hit a: {outcome.Next(3, 10)}");
            //         Console.WriteLine($"the spider hits a: {outcome.Next(1, 5)}");
            //         Console.WriteLine($"You hit a: {outcome.Next(3, 10)}");
     
        // if (edmg1 > fdmg1);
      //   {
      //   Console.WriteLine("The spider has dealt more damage than you!", edmg1);
      //   }
         }
          }
        }
    }
}
            
            
    
