using System;
using System.Collections.Generic;

namespace Mastermind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] answer = CreateAnswer();
            Game game = new Game(answer, 4);
            bool won = false;
            for (int turns = game.guesses; turns > 0; turns--)
            {
                Console.WriteLine("You have {0} tries left!", turns);
                Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball(letters[i].ToString());
                    //These letters come from string that user typed in and entered to the string letters
                }
                Row row = new Row(balls);
                game.rows.Add(row);//this adds the row of the new balls we created to the list of rows in the game
                if (game.Score(row) == "4 - 0")
                {
                    Console.WriteLine("You guessed it correct!");
                    won = true;
                    break;
                }
                else
                    Console.WriteLine(game.Score(row));
            }
            if (won == false)
                Console.WriteLine("Out of turns!");
        }

        private static string[] CreateAnswer()
        {
            string[] answer = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 4);
                char letter = (char)('a' + num);
                answer[4] = letter.ToString();
            }

            return answer;
        }



        public class Ball
        {
            public string Letter { get; private set; }

            public Ball(string letter)
            {
                this.Letter = letter;
            }
        }
        public class Row
        {
            public Ball[] balls = new Ball[4];
            //this creates array of 4 of the Ball class

            public Row(Ball[] balls)
            {
                this.balls = balls;
            }

            public string Balls
            {
                get
                {
                    foreach (var ball in this.balls)
                    {
                        Console.WriteLine(ball.Letter);
                    }
                    return "";
                }
            }
        }

        public class Game
        {
            public List<Row> rows = new List<Row>();

            public string[] answer = new string[4];

            public int guesses = 0;

            public Game(string[] answer, int guesses)
            {
                this.answer = answer;
                this.guesses = guesses;
            }

            public string Score(Row row)
            {
                string[] answerClone = (string[])this.answer.Clone();
                int red = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (answerClone[i] == row.balls[i].Letter)
                        red++;
                }
                int white = 0;
                for (int i = 0; i < 4; i++)
                {
                    int foundIndex = Array.IndexOf(answerClone, row.balls[i].Letter);
                    if (foundIndex > -1)
                    {
                        white++;
                        answerClone[foundIndex] = null;
                    }
                }
                return $"{red} - {white - red}";
            }
        }
    }
}







