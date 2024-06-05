using xadrez_console.board;

namespace xadrez_console;

public class Board(int rows, int columns)
{
    public int Rows { get; set; } = rows;
    public int Columns { get; set; } = columns;
    private Piece[,] Pieces = new Piece[rows, columns];

    public Piece Piece(int row, int column)
    {
        return Pieces[row, column];
    }
}
