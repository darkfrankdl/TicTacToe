namespace program
{
    class Program
    {
        public static void Main (string[] args)
        {
            drawBoard(new string[] { "X", "X", "O", "X", "X", "O", "X", "X", "O" });

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