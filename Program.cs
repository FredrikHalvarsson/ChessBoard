namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string blackSquare = "◼︎";
            string whiteSquare = "◻︎";
            int boardSize = 0;
            bool play=true;
            do
            {
                Console.Clear();
                Console.WriteLine($"{blackSquare} {whiteSquare} {blackSquare} {whiteSquare} {blackSquare} {whiteSquare} {blackSquare} {whiteSquare}\n");
                Console.WriteLine("Chess" +
                    "\n Menu:" +
                    "\n 1. Set board size" +
                    "\n 2. Set board style" +
                    "\n 3. Display board" +
                    "\n 0. Exit" +
                    $"\n\n Board size: {boardSize} x {boardSize}" +
                    $"\nBlack: {blackSquare}" +
                    $"\nWhite: {whiteSquare}" +
                    $"\n \n{whiteSquare} {blackSquare} {whiteSquare} {blackSquare} {whiteSquare} {blackSquare} {whiteSquare} {blackSquare}");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "0":
                        play=false;
                        break;
                    case "1":
                        boardSize=Size();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Change board style" +
                            "\n 1. Change symbol for 'Black' square" +
                            "\n 2. Change symbol for 'White' square" +
                            "\n 3. Reverse colours" +
                            "\n 4. Revert to default");
                        string temp2 = Console.ReadLine();
                        switch (temp2)
                        {
                            case "1":
                                blackSquare=StyleBlack(blackSquare);
                                break;
                            case "2":
                                whiteSquare=StyleWhite(whiteSquare);
                                break;
                            case "3":
                                string blackTemp = blackSquare;
                                blackSquare = whiteSquare;
                                whiteSquare = blackTemp;
                                break;
                            case "4":
                                blackSquare = "◼︎";
                                whiteSquare = "◻︎";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Play(boardSize, whiteSquare, blackSquare);
                        break;
                    default:
                        break;


                }
            } while (play);

        }
        static int Size()
        {
            Console.Clear();
            Console.WriteLine("Hur stort bräde?");
            String sizeString = Console.ReadLine();
            int boardSize = Int32.Parse(sizeString);
            return(boardSize);
        }
        static string StyleBlack(string blackSquare)
        {
            Console.Clear();
            Console.WriteLine("Input symbol for 'Black' squares");
            blackSquare=Console.ReadLine();
            return(blackSquare);
        }
        static string StyleWhite(string whiteSquare)
        {
            Console.Clear();
            Console.WriteLine("Input symbol for 'White' squares");
            whiteSquare = Console.ReadLine();
            return (whiteSquare);
        }
        static string[,] Play(int boardSize, string whiteSquare, string blackSquare)
        {
            Console.Clear();
            string[,] chessBoard = new string[boardSize, boardSize];
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int column = 0; column < chessBoard.GetLength(1); column++)
                {
                    chessBoard[row, column] = ((row + column) % 2 == 0) ? whiteSquare : blackSquare;
                }
            }
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int column = 0; column < chessBoard.GetLength(1); column++)
                {
                    Console.Write(" " + chessBoard[row, column]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return chessBoard;
        }
    }
}