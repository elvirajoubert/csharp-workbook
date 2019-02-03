using System;

namespace Checkpoint1
{
  public class Program
    {
     static void Main(string[] args)
        {
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("Welcome to Checkpoint1!");
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine (" Count of Numbers % by 3 between 1 & 100 ");
            countMod3 ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("              Adding Numbers             ");
            Console.WriteLine ("-----------------------------------------");
            sumNum ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("           Finding Factorials            ");
            Console.WriteLine ("-----------------------------------------");
            factorial ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("             Guessing Game               ");
            Console.WriteLine ("-----------------------------------------");
            guessGame ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("             Maximum Number              ");
            Console.WriteLine ("-----------------------------------------");
            maxNum ();
        }
        /*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        Display the count on the console. */
        public static void countMod3(){

        int count = 0;

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            
            {
                count++;
            }
        }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);
            Console.ReadLine();
        }
        
        /* 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        Calculate the sum of all the previously entered numbers and display it on the console.*/
        public static void sumNum () {
            //while program is not "ok" keep running
            var sum = 0;
            while (true) {
                Console.Write ("Enter a number (or 'Ok' to exit): ");
                var input = Console.ReadLine ();

                if (input.ToLower () == "ok")
                    break;

                sum += Convert.ToInt32 (input);
            }
            Console.WriteLine ("Sum of all numbers is: " + sum);
        }
              /* Write a program and ask the user to enter a number.
        Compute the factorial of the number and print it on the console.
        For example, if the user enters 5, the program should
        calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. */
        public static void factorial () {
            Console.Write ("Enter a number: ");
            var number = Convert.ToInt32 (Console.ReadLine ());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine ("{0}! = {1}", number, factorial);
        }
        /*
        #4 Write a program that picks a random number between 1 and 10.
        Give the user 4 chances to guess the number. If the user guesses the number, display
        “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly,
        you can display the secret number on the console first.)
        */
        public static void guessGame () {
            var number = new Random ().Next (1, 10);
            Console.WriteLine ("You have 4 tries to guess the secret number, ({0})", number);

            for (var i = 0; i < 4; i++) {
                Console.WriteLine ("Guess an interger, between 1-10: ");
                int guess = Convert.ToInt32 (Console.ReadLine ());

                if (guess == number) {
                    Console.WriteLine ("You win!");
                    break;
                } else {
                    Console.WriteLine ("You lost.");
                }
            }
        }
        /*  5- Write a program and ask the user to enter a series of numbers separated by comma.
        Find the maximum of the numbers and display it on the console.
        For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        */
        public static void maxNum () {
            Console.Write ("Enter comma separated numbers: ");
            var input = Console.ReadLine ();

            var numbers = input.Split (',');

            // Assume the first number is the max
            var max = Convert.ToInt32 (numbers[0]);

            foreach (var str in numbers) {
                var number = Convert.ToInt32 (str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine ("Max is " + max);
        }
    }
}
    


