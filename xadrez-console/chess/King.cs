using xadrez_console.board;

namespace xadrez_console.chess;

public class King(Board board, Color color)
    : Piece(board, color)
{
    public override string ToString()
    {
        return "K";
    }
}
