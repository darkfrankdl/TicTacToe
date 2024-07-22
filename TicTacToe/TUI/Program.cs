using InterfaceAdapterLayer;
using System.Runtime.CompilerServices;
namespace program
{
    class Program
    {

        public static void Main (string[] args)
        {
            Gameflow();
        }

        private static void Gameflow ()
        {
            Console.WriteLine("*****************Welcome to TicTacToe*****************");
            //Console.WriteLine("select 1 to play a single game");
            Console.WriteLine("select 1 -> create players, first player one then player 2");

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
                            int playerNumber1 = PlayerNumber();
                            string playerName1 = PlayerName();
                            MakeAPlayer(playerName1, playerNumber1);

                            // player 2
                            int playerNumber2 = PlayerNumber();
                            string playerName2 = PlayerName();
                            MakeAPlayer(playerName2, playerNumber2);


                            drawBoard(new string[9]);

                            break;
                        case 2:
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

        private static string PlayerName ()
        {
            bool goon = true;
            string inputName = string.Empty;
            Console.WriteLine("What is this player's name for the game");

            while (goon)
            {
                try
                {
                    string playerName = Console.In.ReadLine();
                    if (playerName != null && playerName != string.Empty)
                    {
                        inputName = playerName;
                        goon = false;
                    }
                    else
                    {
                        Console.WriteLine("type something... try again");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return inputName;
        }

        private static int PlayerNumber ()
        {
            Console.WriteLine("Game consist of two players, select 1 for player 1 and 2 for player 2");
            int numberForPlayer = -1;
            bool goon = true;
            while (goon)
            {
                try
                {
                    string playerNumber = Console.In.ReadLine();
                    numberForPlayer = int.Parse(playerNumber);
                    if (numberForPlayer != 1 && numberForPlayer != 2)
                    {
                        Console.WriteLine("Give a number of 1 or 2... try again");
                    }
                    else
                    {
                        goon = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return numberForPlayer;
        }

        public static void GamePlaying ()
        {
            bool goon = true;
            InterfaceAdapter adf = new InterfaceAdapter();
            while (goon)
            {
                // game logic here:
                // first player 1 makes a move then player 2 makes a move until all spaces are used
                // or 3 crosses or circles in any line is made 

                DTOPlayer player1 = adf.GetPlayer(1);
            }
        }
        private static void drawBoard (string[] boardStatus)
        {
            
            Console.WriteLine("-------");

            Console.WriteLine($"|{boardStatus[0]}|{boardStatus[1]}|{boardStatus[2]}|");

            Console.WriteLine($"|{boardStatus[3]}|{boardStatus[4]}|{boardStatus[5]}|");

            Console.WriteLine($"|{boardStatus[6]}|{boardStatus[7]}|{boardStatus[8]}|");
        }
    }
}