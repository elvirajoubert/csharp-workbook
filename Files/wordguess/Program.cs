using System;
using System.IO;

namespace GuessGame {
    class Program {
        static void Main (string[] args) {
            string[] lines = File.ReadAllLines (@"C:\Users\Elvira KGB\Documents\wordguess.txt.txt");

            Random rnd = new Random ();
            int r = rnd.Next (lines.Length);
            string compWord = lines[r];

            Console.WriteLine ("Please guess the word in the console and I will give you hints along the way.");
            Console.WriteLine ("The word I picked is {0}", compWord);
            string userGuess = Console.ReadLine ();

            int compNum = Array.IndexOf (lines, compWord);
            int userNum = Array.IndexOf (lines, userGuess);

            while (compNum != userNum) {
                if (compNum < userNum) {
                    Console.WriteLine ("That guess comes after my word! Try again!");
                } else if (userNum < compNum) {
                    Console.WriteLine ("That guess comes before my word! Try again!");
                }
                userGuess = Console.ReadLine ();
                userNum = Array.IndexOf (lines, userGuess);
            }

            if (compNum == userNum) {
                Console.WriteLine ("You guessed it. Nice job!.");
            }
            Console.WriteLine ();

        }
    }
}