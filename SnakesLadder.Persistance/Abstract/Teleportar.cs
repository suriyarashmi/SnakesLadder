using SnakesLadder.Persistance;

namespace SnakesLadder.Persistance.Abstract
{
    public abstract class Teleportar 
    {
        private int tail, head;
        public abstract  void MovePlayer(Player p);
    }
}