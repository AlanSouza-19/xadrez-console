using xadrez_console.board;
using xadrez_console.chess;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {
        Board bd = new Board(8, 8);
        try
        {
            bd.PutPiece(new Rook(bd, Color.White), new Position(0, 0));
            bd.PutPiece(new Rook(bd, Color.White), new Position(0, 7));
            bd.PutPiece(new Rook(bd, Color.Black), new Position(7, 0));
            bd.PutPiece(new Rook(bd, Color.Black), new Position(7, 7));
            Display.PrintBoard(bd);
        } catch (BoardException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}