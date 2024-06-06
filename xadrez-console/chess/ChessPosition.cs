using xadrez_console.board;

namespace xadrez_console.chess;
public class ChessPosition(char column, int row)
{
    public char Column { get; set; } = column;
    public int Row { get; set; } = row;

    public override string ToString()
    {
        return $"{Column}{Row}";
    }

    public Position ToPosition()
    {
        return new Position(8 - Row, Column - 'a');
    }
}
