using System;
using System.Collections;
using System.Collections.Generic;

namespace towerofhanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tower of Hanoi");
            Game towerofHanoiGame = new Game();
            towerofHanoiGame.Play();
        }
    }

    class Blocks
    {
        public int weightedBlock { get; set; }
        public Blocks(int weightedBlock)
        {
            this.weightedBlock = weightedBlock;
        }
    }
    class Towers
    {
        public Stack<Blocks> towerBlocks { get; set; }
        public Towers()
        {
            this.towerBlocks = new Stack<Blocks>();
        }
    }
    class Game
    {
        //declaring variables and definitions
        Dictionary<String, Towers> MakeTowers = new Dictionary<String, Towers>();
        bool win = false;
        string userChoice1 = "";
        bool validMoveFrom = false;
        String moveFrom = "";
        String userChoice2 = "";
        bool validMoveTo = false;
        String movedTo = "";

        //Game Constructor

        public Game()
        {
            MakeTowers["A"] = new Towers();
            MakeTowers["B"] = new Towers();
            MakeTowers["C"] = new Towers();
            //makes blocks for the towers
            Blocks block1 = new Blocks(1);
            Blocks block2 = new Blocks(2);
            Blocks block3 = new Blocks(3);
            Blocks block4 = new Blocks(4);
            //adds blocks to tower A for the initial start of the game
            MakeTowers["A"].towerBlocks.Push(block4);
            MakeTowers["A"].towerBlocks.Push(block3);
            MakeTowers["A"].towerBlocks.Push(block2);
            MakeTowers["A"].towerBlocks.Push(block1);

        }
        public void PrintBoard()
        {
            foreach (String name in MakeTowers.Keys)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(name + ": ");
                Towers tower = MakeTowers[name];
                Stack<Blocks> stackofBlocks = tower.towerBlocks;
                Stack<Blocks> stackPrinted = new Stack<Blocks>();

                foreach (Blocks b in stackofBlocks)
                {
                    stackPrinted.Push(b);
                    foreach (Blocks z in stackPrinted)
                    {
                        System.Console.WriteLine(z.weightedBlock);
                    }
                    System.Console.WriteLine();
                }
            }
        }
        public string UserMoveFrom()
        {
            Console.WriteLine("What tower are you moving your block from? Please choose 'A'  'B' or 'C' ");
            userChoice1 = Console.ReadLine().ToUpper().Trim();
            return userChoice1;
        }
        //validates choice
        public bool ValidMoveFrom(string userChoice1)
        {
            bool validMoveFrom;
            if ((userChoice1 == "A") || (userChoice1 == "B") || (userChoice1 == "C"))
            {
                moveFrom = userChoice1;
                validMoveFrom = true;
            }
            else
            {
                validMoveFrom = false;
                throw new Exception();
            }
            return validMoveFrom;
        }
        //This is what user chooses to move to.
        public string UserMoveTo()
        {
            Console.WriteLine("What tower are you moving your block to? Please choose 'A'  'B' or 'C' ");
            userChoice2 = Console.ReadLine().ToUpper().Trim();
            return userChoice2;
        }
        //validates choice
        public bool ValidMoveTo(string userChoice2)
        {
            // bool validMoveTo;
            if ((userChoice2 == "A") || (userChoice2 == "B") || (userChoice2 == "C"))
            {
                movedTo = userChoice2;
                validMoveTo = true;
            }
            else
            {
                validMoveTo = false;
                throw new Exception();
            }
            return validMoveTo;
        }
        public void MoveBlock()
        {
            //checks to see if from is empty
            if (MakeTowers[moveFrom].towerBlocks.Count == 0)
            {
                throw new Exception();
            }
            var MovingPiece = MakeTowers[moveFrom].towerBlocks.Peek();
            //check for moved To if empty
            if (MakeTowers[movedTo].towerBlocks.Count == 0)
            {
                MakeTowers[moveFrom].towerBlocks.Pop();
                MakeTowers[movedTo].towerBlocks.Push(MovingPiece);
                //check if block in moved to is bigger
            }
            else if (MakeTowers[movedTo].towerBlocks.Peek().weightedBlock > MovingPiece.weightedBlock)
            {
                MakeTowers[moveFrom].towerBlocks.Pop();
                MakeTowers[movedTo].towerBlocks.Push(MovingPiece);
            }
            else
            {
                throw new Exception();
            }

        }
        //time to check for a win
        public void CheckForWin()
        {
            if ((MakeTowers["C"].towerBlocks.Count >= 4) || (MakeTowers["D"].towerBlocks.Count >= 4))
            {
                Console.WriteLine("You Win!");

                win = true;
            }
            else
            {
                win = false;
            }
        }
        //time to play the game
        public void Play()
        {
            while (!win)
            {
            //print board if person does not make valid choices try again
            TryAgain: PrintBoard();
                //User Move From Tower ___
                UserMoveFrom();
                //While not a valid move - keep asking for a move.
                while (!validMoveFrom)
                {
                    try
                    {
                        ValidMoveFrom(userChoice1);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, that input is invalid. Please try again.");
                        Console.WriteLine();
                        goto TryAgain;
                    }
                }

                //User Move block to tower ___
                UserMoveTo();
                //while not a valid move - keep asking where to move
                while (!validMoveTo)
                {
                    // UserMoveTo ();
                    try
                    {
                        ValidMoveTo(userChoice2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, that input is invalid. Please try again.");
                        Console.WriteLine();
                        goto TryAgain;
                    }
                }

                try
                {
                    MoveBlock();
                }
                catch (Exception)
                {
                    if (MakeTowers[moveFrom].towerBlocks.Count == 0)
                    {
                        Console.WriteLine("You are trying to move from a tower that does not contain blocks. Try Again");
                    }
                    else
                    {
                        Console.WriteLine("You are trying to move a bigger block onto a smaller one.. Try Again");
                    }
                    goto TryAgain;
                }
                CheckForWin();
            }
        }
    }
}
