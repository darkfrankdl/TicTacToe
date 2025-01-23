using InterfaceAdapterLayer;
using System.Runtime.CompilerServices;
namespace program
{
    class Program
    {
        static string[,] board = new string[3,3];


        public static void Main (string[] args)
        {
            Gameflow();
        }

        private static void Gameflow ()
        {
            Console.WriteLine("*****************Welcome to TicTacToe*****************");
            Console.WriteLine("select 1 to play with Demo players");

            bool goon = true;
            while (goon)
            {
                string inputFromUser = Console.In.ReadLine();
                if (inputFromUser != null && inputFromUser != string.Empty)
                {
                    int switchInput = int.Parse(inputFromUser);

                    switch (switchInput)
                    {
                        case 1:
                            // player 1
                            int playerNumber1 = 1;
                            string playerName1 = "Joe";
                            MakeAPlayer(playerName1, playerNumber1);

                            // player 2
                            int playerNumber2 = 2;
                            string playerName2 = "Janice";
                            MakeAPlayer(playerName2, playerNumber2);
                            
                            GamePlaying();
                            break;
                        case 0:
                            goon = false;

                            break;
                    }
                }
            }
            
            
        }

        private static bool MakeAPlayer(string playerName, int playerNumber)
        {
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            bool sus = interfaceAdapter.CreatePlayer(playerName, playerNumber);
            return sus;
        }

        public static void GamePlaying ()
        {

            bool goon = true;
            InterfaceAdapter adf = new InterfaceAdapter();
            DTOPlayer player1 = adf.GetPlayer(1);
            DTOPlayer player2 = adf.GetPlayer(2);
            adf.CreateBoard();
            DTOBoard DTOBoard = adf.GetBoard();
            board = DTOBoard.PositionSymbols;

            bool player1Turn = true;
            while (goon)
            {
                // game logic here:
                // first player 1 makes a move then player 2 makes a move until all spaces are used
                // or 3 crosses or circles in any line is made 
                if(CheckIfBoardIsFull(board))
                {
                    goon = false;
                }
                else
                {
                    if (player1Turn)
                    {
                        // it is the first player to make a move.
                        int position = ParseNumberFromUserInput();
                        Tuple<int, int> positionXO = SneakyConverter(position);
                        MakeMove(positionXO, player1.Player1Or2);
                        player1Turn = false;
                        drawBoard(board);

                    }
                    else if (!player1Turn)
                    {
                        // it is the second player to make a move.
                        int position = ParseNumberFromUserInput();
                        Tuple<int, int> positionXO = SneakyConverter(position);
                        MakeMove(positionXO, player2.Player1Or2);
                        player1Turn = true;
                        drawBoard(board);
                    }
                }
            }
        }

        private static void MakeMove(Tuple<int,int> postion, int playerNumber)
        {
            if (board[postion.Item1,postion.Item2] == null)
            {
                // legal to make a move here.
                if(playerNumber == 1)
                {
                    board[postion.Item1, postion.Item2] = "X";
                }
                else if (playerNumber == 2)
                {
                    board[postion.Item1, postion.Item2] = "O";
                }
                
            }
            else
            {
                // illigal move.
                Console.WriteLine("Cannot make move here as there is a piece already");
            }

        }

        private static void drawBoard (string[,] boardStatus)
        {
            
            Console.WriteLine("-------");

            Console.WriteLine($"|{boardStatus[0,0]}|{boardStatus[1,0]}|{boardStatus[2, 0]}|");

            Console.WriteLine($"|{boardStatus[0,1]}|{boardStatus[1,1]}|{boardStatus[2,1]}|");

            Console.WriteLine($"|{boardStatus[0,2]}|{boardStatus[1,2]}|{boardStatus[2,2]}|");
        }

        private static int ParseNumberFromUserInput()
        {
            int number = -1;
            try
            {
                string input = Console.In.ReadLine();
                number = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return number;
        }

        // converts from int to X,Y positions for a [,] array
        private static Tuple<int,int>? SneakyConverter (int number)
        {
            int column = -1;
            int row = -1;
            switch (number)
            {
                case 0:
                    column = 0;
                    row = 0;
                    break;
                case 1:
                    column = 0;
                    row = 1;
                    break;
                case 2:
                    column = 0;
                    row = 2;
                    break;
                case 3:
                    column = 1;
                    row = 0;
                    break;
                case 4:
                    column = 1;
                    row = 1;
                    break;
                case 5:
                    column = 1;
                    row = 2;
                    break;
                case 6:
                    column = 2;
                    row = 0;
                    break;
                case 7:
                    column = 2;
                    row = 1;
                    break;
                case 8:
                    column = 2;
                    row = 2;
                    break;
            }

            Tuple<int, int> tuple = new Tuple<int, int>(row,column);
            return tuple;
        }

        private static bool CheckIfBoardIsFull(string[,] boardState)
        {
            bool isFull = false;
            int numberOfNotNulls = 0;
            foreach (string s in boardState)
            {
                if(s != null)
                {
                    numberOfNotNulls++;
                }
            }
            if(numberOfNotNulls == 9)
            {
                isFull = true;
            }

            return isFull;
        }
    }
}