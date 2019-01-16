using System;

namespace textbasegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int stick = 0;
            int fdmg1 = 0;
            int edmg1 = 0;
            //int complete = 0;
            //Random ran = new Random();
            string choice1 = null;
            string choice2 = null;
            string choice3 = null;

            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            choice1 = Console.ReadLine();
            Console.WriteLine("You chose {0}.", choice1);

            stick = 0;
            if (choice1 == "y" || choice1 == "Y" || choice1 == "Yes" || choice1 == "YES" || choice1 == "yes")
            {

                stick = 1;
                Console.WriteLine("You took the stick");
            }
            else
            {
                Console.WriteLine("You did not take the stick");

                stick = 0;

            }


            Console.WriteLine("As you proceed further into the cave, you will see a small glowing object ");
            Console.WriteLine("Do you approach the object? [y/n]: ");
            choice2 = Console.ReadLine();
            stick = 0;

            Console.WriteLine("You approach the object {0}...", choice2);
            if (choice2 == "y" || choice2 == "Y" || choice2 == "Yes" || choice2 == "YES" || choice2 == "yes")
            {
                //Aproaching spider

                Console.WriteLine("You aproach the object...");
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you take try to fight it? [y/n]: ");
                choice3 = Console.ReadLine();
                {
                    if (stick == 1)
                    {
                        Console.WriteLine("You only have a stick to fight with!", choice3);
                        if (choice3 == "y" || choice3 == "Y" || choice3 == "Yes" || choice3 == "YES" || choice2 == "yes")
                            if (stick == 1)
                            {

                                Console.WriteLine("You quickly jab the spider in its eye and gain an advantage");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("                 Fighting...                                ");
                                Console.WriteLine("          YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER");
                                Console.WriteLine("       IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


                                Random damage = new Random();

                                fdmg1 = damage.Next(3, 10);
                                edmg1 = damage.Next(1, 5);

                                Console.WriteLine($"You hit a {fdmg1}");
                                Console.WriteLine($"The spider hits a {edmg1}");

                                if (edmg1 > fdmg1)
                                {
                                    Console.WriteLine("The spider has dealt more damage than you!");
                                    Console.WriteLine("You died");

                                }
                                else if (edmg1 == fdmg1)
                                {
                                    Console.WriteLine("You did not do enough damage to kill the spider, but you managed to escape.");
                                }
                                else if (edmg1 < fdmg1)
                                {
                                    Console.WriteLine("You killed the spider!");
                                }
                            }

                            else if (stick == 0)
                        {
                            Console.WriteLine("You do not have anything to fight with");
                            Console.WriteLine("     Fighting..      ");
                            Console.WriteLine(" YOU MUST IT ABOVE A 5 TO KILL THE SPIDER  ");
                            Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");

                        }

                    }
                }

            }
        }
    }
}

                    



               

                    
             
        
    
          
                

       
    
           