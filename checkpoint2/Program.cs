using System;
using System.Collections.Generic;
using System.Linq;

namespace checkpoint2 {
    class Program {
        static void Main (string[] args) {
            // intro game
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("~~~~~~~~LETS PLAY CHECKERS~~~~~~~~~");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //make sure encoding is instantiated for printing checker objects
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //instantiates a game object so that the game will run
            Game game = new Game ();

            Console.ReadLine ();
        }
    }
    public class Checker {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }
        public bool King { get; set; }

        public Checker (string color, int[] position) {
            int circleId;
            if (color == "white") {
                circleId = int.Parse ("24C7", System.Globalization.NumberStyles.HexNumber);
            } else {
                circleId = int.Parse ("24D1", System.Globalization.NumberStyles.HexNumber);
                Color = "black";
            }
            this.Symbol = char.ConvertFromUtf32 (circleId);
            this.Position = position;
            this.Color = color;
            this.King = false;

        }
    }

    public class Board {
        public Checker check;
        //the grid is the array used to draw the board
        public string[][] Grid { get; set; }
        //list of checker pieces used to position checkers on the board
        public List<Checker> Checkers { get; set; }
        public Board () {
            //instantiating the board with a list of checkers to create the board
            this.Checkers = new List<Checker> ();
            this.CreateBoard ();

            return;
        }

        public void CreateBoard () {
            this.Grid = new string[][] {
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
            };
            return;

        }
        public void GenerateCheckers () {
            int[][] whitePositions = new int[][] {
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };
            int[][] blackPositions = new int[][] {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 },
            };
            for (int i = 0; i < 12; i++) {
                Checker white = new Checker ("white", whitePositions[i]);
                Checker black = new Checker ("black", blackPositions[i]);
                this.Checkers.Add (white);
                this.Checkers.Add (black);
            }
            return;
        }

        public void PlaceCheckers () {
            foreach (var checker in Checkers) {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }
        public void DrawBoard () {
            CreateBoard ();
            PlaceCheckers ();
            Console.WriteLine ("0 1 2 3 4 5 6 7");
            for (int i = 0; i < 8; i++) {
                Console.WriteLine (i + " " + String.Join (" ", this.Grid[i]));
            }
            return;
        }
        public Checker SelectChecker (int row, int column) {
            return Checkers.Find (x => x.Position.SequenceEqual (new List<int> { row, column }));
        }
        public void RemoveChecker (Checker checker) {
            Checkers.Remove (checker);
            return;
        }
        public bool CheckForWin () {
            if (Checkers.All (x => x.Color == "White") || !Checkers.Exists (x => x.Color == "white")) {
                Console.WriteLine ("White Won!");
            } else {
                Console.WriteLine ("Black Won!");
            }
            return Checkers.All (x => x.Color == "black") || !Checkers.Exists (x => x.Color == "black");
        }

        public Checker SelectCheckerSource (int sourceRow, int sourceColumn) {
            //if source row and column in array
            if ((sourceRow < 0 || sourceRow > 7) || (sourceColumn < 0 || sourceColumn > 7)) {
                throw new Exception ("Your move is off the board.");

            } else if (Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn })) == null) {

                throw new Exception ("There is not a checker at the row and column you entered");
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn }));
        }

        public Checker SelectCheckerDestination (int destRow, int destColumn) {
            Checker check = Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
            //if source row and column in array
            if ((destRow < 0 || destRow > 7) || (destColumn < 0 || destColumn > 7)) {
                throw new Exception ("Your move is off the board.");

            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        // if during checkers game any chosen position == an existing checker position throw exception otherwise valid
        //throw and exception if not diagonal
        public Checker CheckerPreCheck (int sourceRow, int sourceColumn, int destRow, int destColumn, Checker check) {
            check = Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn }));
            // if dest row and dest col have a checker piece using select checker method passing dest
            if (SelectCheckerDestination (destRow, destColumn) != null) {
                throw new Exception ("That space is full.");

            } else if (SelectCheckerDestination (destRow, destColumn) == null) {
                //if moving 2 diagonal spaces jump checker must be opposing (X)
                //1. check if moving two spots (X)
                //2. check if destination removal is not null (&& SelectCheckerDestination(destRow+1,destColumn -1) != null)
                //3. checker symbol being jumped is opposing
                if (Math.Abs (destRow - check.Position[0]) == 2 && Math.Abs (destColumn - check.Position[1]) == 2) {

                    if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == 2) {
                        RemoveChecker (destRow + 1, destColumn - 1);
                        Console.WriteLine ("Nice move");
                    }
                    //remove the checker row up to column left
                    else if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == -2) {
                        RemoveChecker (destRow + 1, destColumn + 1);

                        Console.WriteLine ("Nice move");
                    }

                    //remove the checker row behind me to column right
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == 2) {
                        RemoveChecker (destRow - 1, destColumn - 1);
                        Console.WriteLine ("Nice move");
                    }
                    //remove the checker down to left
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == -2) {
                        RemoveChecker (destRow - 1, destColumn + 1);

                        Console.WriteLine ("Nice move");
                    }

                    //check for a diagonal move - regular
                } else if (Math.Abs (destRow - check.Position[0]) == 1 &&
                    Math.Abs (destColumn - check.Position[1]) == 1) {
                    Console.WriteLine ("Nice diagonal move!");
                    return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
                } else {
                    Console.WriteLine (" ");

                    throw new Exception ("You cannot move here. Does not meet requirements to move.");
                }
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        //allows a checker to be removed
        public void RemoveChecker (int destRow, int destColumn) {
            Checker cx2 = SelectCheckerDestination (destRow, destColumn);
            Checkers.Remove (cx2);
        }
        //king a checker takes in a checker object and a destRow to determine if the Checker is to be Kinged on that move
        public void KingChecker (Checker checker, int destRow) {
            if ((checker.Color == "black" && destRow == 7) || (checker.Color == "white" && destRow == 0)) {
                checker.King = true;
                if (checker.Color == "black") {
                    int kingId = int.Parse ("24C7", System.Globalization.NumberStyles.HexNumber);
                    string king = char.ConvertFromUtf32 (kingId);
                    checker.Symbol = king;
                } else {
                    int kingId = int.Parse ("24D1", System.Globalization.NumberStyles.HexNumber);
                    string king = char.ConvertFromUtf32 (kingId);
                    checker.Symbol = king;
                }
                PlaceCheckers ();
            }
        }

        public void MoveCheckers () {

            Console.WriteLine ("(Choose a number between 0-7)");
            Console.WriteLine ("Pick up Checker on Row: ");
            int sourceRow = Int32.Parse (Console.ReadLine ().Trim ());
            Console.WriteLine ("Pick up Checker on Column: ");
            int sourceColumn = Int32.Parse (Console.ReadLine ().Trim ());
            Checker cx = SelectCheckerSource (sourceRow, sourceColumn);
            Console.WriteLine ("Place Checker on Row: ");
            int destRow = Int32.Parse (Console.ReadLine ().Trim ());
            Console.WriteLine ("Place Checker on Column: ");
            int destColumn = Int32.Parse (Console.ReadLine ().Trim ());
            CheckerPreCheck (sourceRow, sourceColumn, destRow, destColumn, check);
            cx.Position = new int[] { destRow, destColumn };
            // check for a king 
            KingChecker (cx, destRow);
            //creates the board again
            CreateBoard ();
            //places checkers on the newly created board
            PlaceCheckers ();
            return;
        }

    }

    class Game {
        public Game () {
            // determines turns
            bool turn = true;

            //initialize the game by creating a board object and apply board methods
            Board board = new Board ();
            board.CreateBoard ();
            board.GenerateCheckers ();
            board.PlaceCheckers ();
            Console.WriteLine ("To play you will select rows and columns\nto move pieces throughout the field.");
            do {
                //draw the board to play. on loop checkers will remember they have new positions.
                //try again for try catch exceptions.
                TryAgain : board.DrawBoard ();

                if (turn) {
                    Console.WriteLine ();
                    Console.WriteLine ("White, Your Move");
                    turn = false;
                } else {
                    Console.WriteLine ();
                    Console.WriteLine ("Black, Your Move");
                    turn = true;
                }
                try {
                    board.MoveCheckers ();
                } catch (Exception e) {
                    Console.WriteLine ();
                    Console.WriteLine ("There was an error: {0}", e);
                    Console.WriteLine ("Please try your move again.");
                    goto TryAgain;
                }
            }
            while (!board.CheckForWin ());

        }
    }
}