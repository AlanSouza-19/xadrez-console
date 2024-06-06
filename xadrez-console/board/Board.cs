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

    public Piece Piece(Position pos)
    {
        return Pieces[pos.Row, pos.Column];
    }

    public void PutPiece(Piece p, Position pos)
    {
        if (ExistPiece(pos))
        {
            throw new BoardException("A piece in this position already exists!");
        }
        Pieces[pos.Row, pos.Column] = p;
        p.Position = pos;
    }

    public bool ExistPiece(Position pos)
    {
        ValidatePosition(pos);
        return Piece(pos) != null;
    }

    public bool ValidPosition(Position pos)
    {
        if (pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns)
        {
            return false;
        } else {
            return true;
        }
    }

    public void ValidatePosition(Position pos)
    {
        if (!ValidPosition(pos))
        {
            throw new BoardException("Invalid Position!");
        }
    }
}
