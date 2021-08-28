using SnakesLadder.Persistance;

namespace SnakesLadder.Persistance.Abstract
{
    public abstract class Teleportar 
    {
        private int tail, head;

        public int Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public int Tail
        {
            get
            {
                return tail;
            }
            set
            {
                tail = value;
            }
        }
        protected Teleportar(int head, int tail)
        {
            this.head = head;
            this.tail = tail;
        }

        public abstract  void MovePlayer(Player p);

    }
}