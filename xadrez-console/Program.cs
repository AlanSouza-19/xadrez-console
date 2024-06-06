using xadrez_console.board;
using xadrez_console.chess;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {
        Board bd = new (8, 8);
        try
        {
            ChessPosition cp = new ChessPosition('c', 7);
            Console.WriteLine(cp.ToPosition());
        } catch (BoardException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}