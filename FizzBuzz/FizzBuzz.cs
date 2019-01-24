using System;

namespace FizzBuzz
{
    class Program
    {
        /*
          FizzBuzz:
          Count from the number 1
          Any number divisible by 3 = Fizz
          Any number divisible by 5 = Buzz
          Numbers that are divisible by both = FizzBuzz
           */

        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz!");
            Console.WriteLine("Please, Enter a Number...");
            int numEntered = Convert.ToInt32(Console.ReadLine());
            fizzBuzz(numEntered);


        }

        public static void fizzBuzz(int numEntered)
        {
            for (int i = numEntered; i < 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("buzz");
                    Console.WriteLine(i);
                }
            }
        }
    }
}




