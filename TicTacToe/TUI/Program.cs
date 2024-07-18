using InterfaceAdapterLayer;
namespace program
{
    class Program
    {

        public static void Main (string[] args)
        {
            Game game = new Game();
            DTOPlayer player1 = game.CreatePlayer("CrossPlayer");
            DTOPlayer player2 = game.CreatePlayer("CirclePlayer");

            drawBoard(game.Board);

            game.MakeMove(player1, 2);
            game.MakeMove(player2, 3);
            game.MakeMove(player1, 3);

            drawBoard(game.Board);
        }

        private static void drawBoard (string[] boardStatus)
        {
            
            Console.WriteLine("-------");

            Console.WriteLine($"|{boardStatus[0]}|{boardStatus[1]}|{boardStatus[2]}|");

            Console.WriteLine($"|{boardStatus[3]}|{boardStatus[4]}|{boardStatus[5]}|");

            Console.WriteLine($"|{boardStatus[6]}|{boardStatus[7]}|{boardStatus[8]}|");
        }
    }

    class Game : IGame
    {
        public Game()
        {
            Board = new string[9];
        }

        public DTOPlayer CreatePlayer(string name)
        {
            return new DTOPlayer(name);
        }

        public string [] Board { get; set; }
        public int MakeMove(DTOPlayer currentPlayer, int wantedPlayerMove)
        {
            int placementOfMoveOnBoard = -1;
            if (wantedPlayerMove >= 1 && wantedPlayerMove <= 9)
            {
                string allowedLetterForMove = string.Empty;
                if (currentPlayer != null && currentPlayer.Name == "CrossPlayer")
                {
                    allowedLetterForMove = "X";
                }
                else if (currentPlayer.Name == "CirclePlayer")
                {
                    allowedLetterForMove = "O";
                }

                if (Board[wantedPlayerMove - 1] == null)
                {
                    Board[wantedPlayerMove - 1] = allowedLetterForMove;
                    placementOfMoveOnBoard = wantedPlayerMove - 1;
                }
                else
                {
                    Console.WriteLine("Move not legal as there is a piece already");
                    Console.WriteLine("the borad is divided into numbers that is");
                    Console.WriteLine("1,2,3");
                    Console.WriteLine("4,5,6");
                    Console.WriteLine("7,8,9");
                }
            }
            else
            {
                Console.WriteLine("Error move is out of the board, allowed placements are 1 - 9");

            }

            return placementOfMoveOnBoard;
        }
    }
}