using xadrez_console.board;
using xadrez_console.chess;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {
        Board bd = new (8, 8);
        try
        {
            bd.PutPiece(new Rook(bd, Color.Black), new Position(0, 8));
            bd.PutPiece(new Rook(bd, Color.Black), new Position(0, 0));
            bd.PutPiece(new Rook(bd, Color.Black), new Position(0, 7));
            Display.PrintBoard(bd);
            Console.ReadLine();
        } catch (BoardException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}