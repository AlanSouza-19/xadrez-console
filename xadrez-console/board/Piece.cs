namespace xadrez_console.board;

public class Piece(Board board, Color color)
{
    public Position Position { get; set; } = null;
    public Color Color { get; protected set; } = color;
    public int NumberOfMoves { get; protected set; } = 0;
    public Board Board { get; protected set; } = board;

    public void IncrementNumberOfMoviments()
    {
        NumberOfMoves++;
    }
}
