using System;

namespace TicTacToe {
    class Program {
        //playerTurn will change between X and O as needed for game play
        public static string playerTurn = "X";
        //this array  creates the board and hold the data for X & O
        public static string[][] board = new string[][] {
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " }
        };
        //this is the main fx that runs the game. it will keep playing until a win or tie.
        public static void Main () {
            do {
                DrawBoard ();
                GetInput ();
            } while (!CheckForWin () && !CheckForTie ());
            //if win or tie is found then this will print a display to the players
            if (CheckForWin () == true) {
                DrawBoard ();
                Console.WriteLine ("There is a WINNER. It is NOT player {0}!", playerTurn);
            } else if (CheckForTie () == true) {
                DrawBoard ();
                Console.WriteLine ("This game is a TIE!");
            }
            // leave this command at the end so your program does not close automatically
            //wanted to ALERT users to close the app.
            Console.WriteLine ("Press Enter to Close Application");
            Console.ReadLine ();

            bool test = true;
            if (!test){
               test = testTicTacToe () ;
               Console.WriteLine("Your test is {0}", test);
            } else {
                Console.WriteLine ("Your test is {0}", test);
            }
        }
        //getInput fx takes user input and uses it to fill board and call PlaceMark
        public static void GetInput () {
            Console.WriteLine ("Player " + playerTurn);
            Console.WriteLine ("Enter Row:");
            int row = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Enter Column:");
            int column = int.Parse (Console.ReadLine ());
            PlaceMark (row, column);
            playerTurn = (playerTurn == "X") ? "O" : "X";
        }
        //this will reference the board and check for input, if input found prompts to try again.
        public static string PlaceMark (int row, int column) {
            //X is default using ternary operator
            if (board[row][column] == " ") {
                board[row][column] = playerTurn;
                return playerTurn;
            } else if (board[row][column] == "X" || board[row][column] == "O") {
                Console.WriteLine ("This space is taken...try again.");
                GetInput ();
                //ternary opporator changes the player.
                playerTurn = (playerTurn == "X") ? "O" : "X";
            }
            return playerTurn;
        }
        //checks all win conditions for a win.
        public static bool CheckForWin () {
            // your code goes here
            if (HorizontalWin () == true) {
                return true;
            } else if (VerticalWin () == true) {
                return true;
            } else if (DiagonalWin () == true) {
                return true;
            } else {
                return false;
            }
        }
        //looks at the number of spaces - player keep playing until you win or there are no spaces left and you tie.
        public static bool CheckForTie () {
            // your code goes here
            int spaceAvail = 9;
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == "X" || board[i][j] == "O") {
                        spaceAvail--;
                    }
                }
            }
            if (spaceAvail <= 0 && !CheckForWin () == true) {
                return true;
            } else {
                return false;
            }
        }

        public static bool HorizontalWin () {
            // check each row for same player input
            if (board[0][0] == "X" && board[0][1] == "X" && board[0][2] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[0][1] == "O" && board[0][2] == "O") {
                return true;
            } else if (board[1][0] == "X" && board[1][1] == "X" && board[1][2] == "X") {
                return true;
            } else if (board[1][0] == "O" && board[1][1] == "O" && board[1][2] == "O") {
                return true;
            } else if (board[2][0] == "X" && board[2][1] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[2][0] == "O" && board[2][1] == "O" && board[2][2] == "O") {
                return true;
            } else {
                return false;
            }
        }

        public static bool VerticalWin () {
            // check each column for same player input
            if (board[0][0] == "X" && board[1][0] == "X" && board[2][0] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[1][0] == "O" && board[2][0] == "O") {
                return true;
            } else if (board[0][1] == "X" && board[1][1] == "X" && board[2][1] == "X") {
                return true;
            } else if (board[0][1] == "O" && board[1][1] == "O" && board[2][1] == "O") {
                return true;
            } else if (board[0][2] == "X" && board[1][2] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[0][2] == "O" && board[1][2] == "O" && board[2][2] == "O") {
                return true;
            } else {
                return false;
            }
        }

        public static bool DiagonalWin () {
            // check ["0,0"; "1,1"; "2,2"] && check ["0,2" ; "1,1" ; "2,0"]
            if (board[0][0] == "X" && board[1][1] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[1][1] == "O" && board[2][2] == "O") {
                return true;
            } else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O") {
                return true;
            } else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O") {
                return true;
            } else {
                return false;
            }
        }

        public static void DrawBoard () {
            Console.WriteLine ("  0 1 2 ");
            Console.WriteLine ("0 " + String.Join ("|", board[0]));
            Console.WriteLine ("  ------");
            Console.WriteLine ("1 " + String.Join ("|", board[1]));
            Console.WriteLine ("  ------");
            Console.WriteLine ("2 " + String.Join ("|", board[2]));
        }
        //add tests 1 per main method.
        public static bool testTicTacToe () {
            PlaceMark(0,0);
            PlaceMark(1,0);
            PlaceMark(0,1);
            PlaceMark(1,1);
            PlaceMark(0,2);
            if (CheckForWin() == true) {
                if (HorizontalWin () == true) {
                    return true;
                }
            } else {
                return false;
            }
            return false;
        }
    }
}