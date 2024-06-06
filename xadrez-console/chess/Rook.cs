using xadrez_console.board;

namespace xadrez_console.chess;

public class Rook(Board board, Color color)
    : Piece(board, color)
{
    public override string ToString()
    {
        return "R";
    }
}
