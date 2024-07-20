using InterfaceAdapterLayer;
namespace program
{
    class Program
    {

        public static void Main (string[] args)
        {
            string playerName = PlayerInput(true);
            string playerNumber = PlayerInput(false, true);
            int number = int.Parse(playerNumber);
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            bool sus = interfaceAdapter.CreatePlayer(playerName, number);
            Console.WriteLine($"Creating a player was a sucess: {sus})");
            Console.ReadLine();
        }

        private static string PlayerInput (bool isPlayerNameInput = false, bool isPlayerNumberInput = false)
        {
            bool goon = true;
            string input = string.Empty;
            string forText = string.Empty;

            if (isPlayerNameInput)
            {
                Console.WriteLine("What is this player's name");
                forText = "name";
            }
            else if (isPlayerNumberInput)
            {
                Console.WriteLine("Is this player, player 1 or 2?, type 1 for player 1 or 2 for player 2");
                forText = "number: either 1 or 2";
            }

            if(isPlayerNameInput && !isPlayerNumberInput || !isPlayerNameInput && isPlayerNumberInput)
            {
                while (goon)
                {
                    input = Console.In.ReadLine();
                    if (input != null && input != string.Empty)
                    {
                        if (!isPlayerNameInput && isPlayerNumberInput)
                        {
                            if (input == "1" || input == "2")
                            {
                                goon = false;
                            }
                            else if (input != "1" || input != "2")
                            {
                                ErrorMessage(forText);
                            }
                        }
                        else
                        {
                            goon = false;
                        }
                    }
                    else
                    {
                        input = string.Empty;
                        ErrorMessage(forText);
                    }
                }
            }
            return input;
        }

        private static void ErrorMessage (string forText)
        {
            Console.WriteLine($"Give {forText} please: ... ");
        }

        private static int SetIfPlayerIsPlayer1Or2 ()
        {
            string playerNumber = Console.In.ReadLine();
            int number = int.Parse(playerNumber);
            return -1;
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