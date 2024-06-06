using xadrez_console.board;

namespace xadrez_console.chess;
public class ChessGame
{
    public Board Board {get; private set;} = new Board(8, 8);
    private int Turn = 1;
    private Color JogadorAtual = Color.White;
    public bool Finished {get; private set;}

    public ChessGame()
    {
        Board = new Board(8, 8);
        Turn = 1;
        JogadorAtual = Color.White;
        Finished = false;
        PutPieces();
    }

    public void ExecuteMoviment(Position origin, Position destiny)
    {
        Piece p = Board.RemovePiece(origin);
        p.IncrementNumberOfMoviments();
        Piece CapturedPiece = Board.RemovePiece(destiny);
        Board.PutPiece(p, destiny);
    }

    private void PutPieces()
    {
        Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('a', 1).ToPosition());
        Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('h', 1).ToPosition());
        Board.PutPiece(new King(Board, Color.White), new ChessPosition('e', 1).ToPosition());

        Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('a', 8).ToPosition());
        Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('h', 8).ToPosition());
        Board.PutPiece(new King(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
    }
}
