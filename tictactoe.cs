 class Program
    {
        static void Main(string[] args)
        {
            //start board
            string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            //greeting
            Console.WriteLine("welcome to tic tac toe!");

            //board function
            showboard(board);

            //starting player current player 
            string currentplayer = "X";

            //main game loop
            while (true)
            {
                // players move funtion
                int position = GetPlayerMove(currentplayer, board);

                // show current player move on board
                board[position - 1] = currentplayer;

                //show the updated board
                showboard(board);

                // who won checking function 
                bool haswinner = wincheck(board, currentplayer);

                //if function returns true announce victor
                if (haswinner == true)
                {
                    Console.WriteLine($"{currentplayer} has claimed victory!");
                    break;
                }

                //is the board full fucntion check
                // if board is filled game is a draw, write to screen and end game
                bool fullboard = fullboardcheck(board);
                if (fullboard)
                {
                    Console.WriteLine($"tied game");
                    break;
                }

                // if check returns false. change current player for next turn.
                currentplayer = nextturn(currentplayer);

            }

            Console.ReadLine();
        }

        private static string nextturn(string currentplayer)
        {
            if (currentplayer == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        private static bool fullboardcheck(string[] board)
        {
            foreach (var box in board)
            {
                if (box != "X" && box != "X")
                {
                    return false;
                }
            }
            return true;
        }

        private static bool wincheck(string[] board, string currentplayer)
        {
            if (board[0] == currentplayer && board[1] == currentplayer && board[2] == currentplayer)
            {
                return true;
            }
            if (board[3] == currentplayer && board[4] == currentplayer && board[5] == currentplayer)
            {
                return true;
            }
            if (board[6] == currentplayer && board[7] == currentplayer && board[8] == currentplayer)
            {
                return true;
            }
            if (board[0] == currentplayer && board[3] == currentplayer && board[6] == currentplayer)
            {
                return true;
            }
            if (board[1] == currentplayer && board[4] == currentplayer && board[7] == currentplayer)
            {
                return true;
            }
            if (board[2] == currentplayer && board[5] == currentplayer && board[8] == currentplayer)
            {
                return true;
            }
            if (board[0] == currentplayer && board[4] == currentplayer && board[8] == currentplayer)
            {
                return true;
            }
            if (board[2] == currentplayer && board[4] == currentplayer && board[6] == currentplayer)
            {
                return true;
            }

            return false;
        }

        private static int GetPlayerMove(string currentplayer, string[] board)
        {
            int moveint;

            while (true)
            {
                if (currentplayer == "O") //that's the AI!
                {
                    moveint = GetAIMove(board);
                }
                else //that's the human player
                {
                    Console.WriteLine($"your move, {currentplayer}");
                    string move = Console.ReadLine();


                    bool wasSuccessfullyParsed = int.TryParse(move, out moveint);
                    if (!wasSuccessfullyParsed)
                    {
                        Console.WriteLine("Not a valid number!!!");
                        continue;
                    }
                }



                if (moveint < 1 || moveint > 9)
                {
                    Console.WriteLine("Not a valid number range!!!");
                    continue;
                }

                if (board[moveint - 1] == "X" || board[moveint - 1] == "O")
                {
                    Console.WriteLine("Can't Play There!!!");
                    continue;
                }

                return moveint;
            }


        }

        private static int GetAIMove(string[] board)
        {

            ////STUPID AI
            //Random r = new Random();
            //var choice = r.Next(1,10);
            //return choice;

            //pretend to play at position 1


            //CHECK FOR IMMEDIATE WIN
            for (int i = 1; i <= 9; i++)
            {
                bool madethePlay = UpdateBoard(board, i, "O");
                // who won checking function 
                bool haswinner = wincheck(board, "O");

                if (madethePlay)
                {
                    ClearSpot(board, i);
                }

                if (haswinner)
                    return i;

            }

            //CHECK FOR THE BLOCK
            for (int i = 1; i <= 9; i++)
            {
                bool madethePlay = UpdateBoard(board, i, "X");
                // who won checking function 
                bool haswinner = wincheck(board, "X");


                if (madethePlay)
                {
                    ClearSpot(board, i);
                }

                if (haswinner)
                    return i;

            }


            //Smart AI
            if (board[4] == "5")
            {
                return 5;
            }

            if (board[0] == "1")
            {
                return 1;
            }

            if (board[2] == "3")
            {
                return 3;
            }
            if (board[6] == "7")
            {
                return 7;
            }

            if (board[8] == "9")
            {
                return 9;
            }

            if (board[1] == "2")
            {
                return 2;
            }

            if (board[3] == "4")
            {
                return 4;
            }

            if (board[5] == "6")
            {
                return 6;
            }

            return 8;

        }

        private static void ClearSpot(string[] board, int i)
        {
            board[i - 1] = i.ToString();
        }

        private static bool UpdateBoard(string[] board, int i, string player)
        {
            if (board[i - 1] == "X" || board[i - 1] == "O")
            {
                return false;
            }
            else
            {
                board[i - 1] = player;
                return true;
            }
        }



        private static void showboard(string[] b)
        {
            Console.Clear();
            Console.WriteLine($"{b[0]} | { b[1]} | { b[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{b[3]} | { b[4]} | { b[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{b[6]} | { b[7]} | { b[8]}");



        }
    }
