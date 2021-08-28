using SnakesLadder.Persistance.Abstract;

namespace SnakesLadder.Persistance.Models
{
   public class Snake : Teleportar
    {
        
        public Snake(int head, int tail) : base (head, tail)
        {
            
        }

        public override void MovePlayer(Player p)
        {
            p.SetPosition(Tail);
        }
    }
}