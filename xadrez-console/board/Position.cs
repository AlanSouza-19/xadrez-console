namespace xadrez_console.board;
public class Position(int row, int column) {
    public int Row { get; set; }
    public int Column { get; set; }

    public override string ToString()
    {
        return $"{row}, {column}";
    }
}
