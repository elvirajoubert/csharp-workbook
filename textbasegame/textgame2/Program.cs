using System;
using System.Threading;

namespace textbasegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int stick = 0;
            int fdmg1 = 0;
            int edmg1 = 0;
            int complete = 0;
            Random ran = new Random();
            string choice1 = null;
            string choice2 = null;
            string choice3 = null;

            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            choice1 = Console.ReadLine();
            Console.WriteLine("You chose {0}.", choice1);
            //first IF statement
            stick = 0;
            if (choice1 == "y" || choice1 == "Y" || choice1 == "Yes" || choice1 == "YES" || choice1 == "yes")
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
            choice2 = Console.ReadLine();
            stick = 0;

            Console.WriteLine("You approach the object {0}...", choice2);
            if (choice2 == "y" || choice2 == "Y" || choice2 == "Yes" || choice2 == "YES" || choice2 == "yes")
            {
                Thread.Sleep(2000);
                Console.WriteLine("You aproach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you take try to fight it? [y/n]: ");
                choice3 = Console.ReadLine();
                stick = 1;
            }
            else
            {
                Console.WriteLine("You did not take the stick");
                Thread.Sleep(2000);
                stick = 0;
            }
            /*
            HERE: What happens if I choose yes && I have the stick
            VS : I choose yes && !HAVE stick
            You need an else if for no stick and your if should include all yes conditions plus (&& stick == 1);
            */
            Console.WriteLine("You only have a stick to fight with!", choice3);
            if (choice3 == "y" || choice3 == "Y" || choice3 == "Yes" || choice3 == "YES" || choice2 == "yes")
                if (stick == 1)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You quickly jab the spider in its eye and gain an advantage");
                    Thread.Sleep(2000);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("                 Fighting...                                ");
                    Console.WriteLine("          YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER"         );
                    Console.WriteLine("       IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE"     );
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Thread.Sleep(2000);

                    Console.WriteLine("You hit a {0}", ran.Next(3, 10));
                    Console.WriteLine("The spider hits a {0}", ran.Next(1, 5));
                    Thread.Sleep(2000);
                    //Random outcome = new Random();
                    fdmg1 = ran.Next();
                    edmg1 = ran.Next();

                    if (edmg1 >= fdmg1)
                    {
                        Console.WriteLine("The spider has dealt more damage than you!");
                        complete = 0;

                    }
                }
                else if (fdmg1 < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape");
                    complete = 1;
                }
                else
                {
                    Console.WriteLine("You have killed the spider");
                    complete = 1;

                    //wihtout stick
                }
            else
            {
                Console.WriteLine("You don't have anything to fight with!");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                 Fighting...                                ");
                Console.WriteLine("          YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER");
                Console.WriteLine("       IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Thread.Sleep(2000);

                Console.WriteLine("You hit a {0}", fdmg1.Next(3, 10));
                Console.WriteLine("The spider hits a {0}", edmg1.Next(1, 5));
                Thread.Sleep(2000);

                /*int fdmg1 = fdmg1.Next();
                int edmg1 = edmg1.Next();*/

                if (edmg1 > fdmg1)
                {
                    Console.WriteLine("The spider has dealt more damage than you!");
                    complete = 0;


                }
                else if (fdmg1 < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape");
                    complete = 1;
                }
                else
                {
                    Console.WriteLine("You have killed the spider");
                    complete = 1;

                    /*fdmg1 = int (random.randint(1, 8))
                    edmg1 = int (random.randint(1, 5))
                    print("you hit a", fdmg1)
                    print("the spider hits a", edmg1)
                    time.sleep(2)

                    if edmg1 > fdmg1:
                        print("The spider has dealt more damage than you!")
                        complete = 0
                        return complete

                    elif fdmg1< 5:
                        print ("You didn't do enough damage to kill the spider, but you manage to escape")
                        complete = 1
                        return complete*/


                }
            }
        }
    }
}