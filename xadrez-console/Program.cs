using xadrez_console.board;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {
        Position p = new (1, 2);
        Console.WriteLine("Position: " + p);
        Console.ReadLine();
    }
}