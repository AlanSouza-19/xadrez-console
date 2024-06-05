namespace xadrez_console.board;
public class Position(int row, int column)
{
    public int Row { get; set; } = row;
    public int Column { get; set; } = column;

    public override string ToString()
    {
        return $"{Row}, {Column}";
    }
}
