using xadrez_console.board;
using xadrez_console.chess;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {

        try
        {
            ChessGame chessMatch = new ChessGame();

            while (!chessMatch.Finished)
            {
                Console.Clear();
                Display.PrintBoard(chessMatch.Board);

                Console.WriteLine();
                Console.Write("Origin: ");
                Position origin = Display.ReadChessPosition().ToPosition();
                Console.Write("Destiny: ");
                Position destiny = Display.ReadChessPosition().ToPosition();

                chessMatch.ExecuteMoviment(origin, destiny);
            }
        } catch (BoardException e) {
            Console.WriteLine(e.Message);
        }
    }
}