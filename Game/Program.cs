using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Player[] players = { new Player(0, "Player 1", false), new Player(0, "Player 2", true) };
            Dice d = new Dice();
            Game g = new Game(b, players, d);
            while (g.GetWinner() == null)
            {
                Player current = g.GetCurrentPlayer();
                if (!current.IsCompPlayer())
                {
                    Console.Write("{0}'s turn to move: ", current.GetName());
                    Console.ReadLine();
                }
                g.RunTheGame();
            }
        }
    }
}
