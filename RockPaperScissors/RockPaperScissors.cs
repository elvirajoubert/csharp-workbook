﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine(hand1);
            Console.WriteLine("Enter hand 2:");
            Console.WriteLine(hand2);
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            return hand1 + ' ' + hand2;

            if (hand1 == "rock" && "paper")
                

        }
    }
}
