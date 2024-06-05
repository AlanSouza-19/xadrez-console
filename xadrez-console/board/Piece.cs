namespace xadrez_console.board;

public class Piece(Position position, Color color, Board board)
{
    public Position Position { get; set; } = position;
    public Color Color { get; set; } = color;
    public int NumberOfMoves { get; set; } = 0;
    public Board Board { get; set; } = board;
}
