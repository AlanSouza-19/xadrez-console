namespace xadrez_console.board;

public class Piece(Position position, Color color, Board board)
{
    public Position Position { get; set; } = position;
    public Color Color { get; protected set; } = color;
    public int NumberOfMoves { get; protected set; } = 0;
    public Board Board { get; protected set; } = board;
}
