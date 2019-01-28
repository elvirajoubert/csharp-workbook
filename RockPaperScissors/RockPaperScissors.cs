using System;

namespace RockPaperScissors
{
    class Program
    {
        static int count = 0;
        static int count1 = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine(hand1);
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(hand2);

            Console.WriteLine(CompareHands(hand1, hand2));
            Console.WriteLine("Hand1 wins " + count + " times");
            Console.WriteLine("Hand2 wins " + count1 + " times");
        
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string CompareHands(string hand1, string hand2)
        {
            //check for tie
            if (hand1 == hand2)
            {
                return "It's a tie";
            }

            if (hand1 == "rock" && hand2 == "paper")
            {
                count1 += 1;
                return "Hand2 Won!";

            }

            else if (hand1 == "paper" && hand2 == "scissors")
            {
                count1 += 1;
                return "Hand2 Won!";

            }
            else if (hand1 == "scissors" && hand2 == "rock")
            {
                count1 += 1;
                return "Hand2 Won!";

            }
            else if (hand1 == "paper" && hand2 == "rock")
            {
                count += 1;
                return "Hand1 Won!";

            }

            else if (hand1 == "rock" && hand2 == "scissors")
            {
                count += 1;
                return "Hand1 Won!";

            }
            else if (hand1 == "scissors" && hand2 == "paper")
            {
                count += 1;
                return "Hand1 Won!";

            }
            else
            {
                return "Unknow winner";
            }
            
         
            
        }
    }
}




