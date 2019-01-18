using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            int Rock;
            int Paper;
            int Scissors;
            var choice1 = Rock && !Paper;
            var choice2 = Scissors && Paper;
            var choice3 = Scissors && Rock;

            return hand1 + ' ' + hand2;
        }
    }
}
