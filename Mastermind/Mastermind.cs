﻿using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Ball
    {
        public string Letter { get; private set; }

        public Ball(string letter)
        {
            this.Letter = letter;
        }
    }
    class Row
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

    class Game
    {
        public List<Row> rows = new List<Row>();
        //this creates a private list of the Row class
        public string[] answer = new string[4];
        // this creates a new array of strings with the size of 4 to hold our answer
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
    class program
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
                //this reads the chosen letters as a string letters
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                //this checks each one of the balls
                {
                    balls[i] = new Ball(letters[i].ToString());
                    //each of the 4 balls created in the array are assigned to a string of one letter
                    //these letters come from string that user typed in and entered to the string letters
                }
                Row row = new Row(balls);
                //this makes a new Row called row where we pass in the users' balls, all now in their own separate strings
                game.rows.Add(row);
                //this adds the row of the new balls we created to the list of rows in the game

                //this checks if the correct answer has been guessed every turn
                if (game.Score(row) == "4 - 0")
                {
                    Console.WriteLine("You win!");
                    won = true;
                    break;
                }
                else
                    Console.WriteLine(game.Score(row));
                //this shows the score (red and white) for that particular turn
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
                answer[i] = letter.ToString();
            }
            return answer;
        }
    }
}