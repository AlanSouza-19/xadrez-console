﻿using xadrez_console.board;

namespace xadrez_console;
class Program {
    public static void Main(string[] args) {
        Board bd = new (8, 8);


        Console.WriteLine("Position: " + bd);
        Console.ReadLine();
    }
}