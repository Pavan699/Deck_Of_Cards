using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deck of Cards Program for $4 Players");
            Players p = new Players();
            p.Suffel();
        }
    }
}
