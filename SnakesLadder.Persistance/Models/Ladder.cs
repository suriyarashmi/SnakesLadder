using SnakesLadder.Persistance.Abstract;

namespace SnakesLadder.Persistance.Models
{
    public  class Ladder : Teleportar
    {
        

        public Ladder(int head, int tail) : base (head, tail)
        {
          
        }

        public override void MovePlayer(Player p)
        {
            p.SetPosition(Head);
        }
    }
}