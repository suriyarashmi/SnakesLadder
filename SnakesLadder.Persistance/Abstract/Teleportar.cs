using SnakesLadder.Persistance;

namespace SnakesLadder.Persistance.Abstract
{
    /// <summary>
    /// Abstract class representing snake and ladder
    /// </summary>
    public abstract class Teleportar 
    {
        //fields
        private int tail, head;

        /// <summary>
        /// property to get and set the value of the private attribute head
        /// </summary>
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
        /// <summary>
        /// property to get and set the value of the private attribute tail
        /// </summary>
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

        /// <summary>
        /// Teleporter class constructor
        /// </summary>
        /// <param name="head">Head of the Teleporter class</param>
        /// <param name="tail">The tail of the Teleporter class</param>
        protected Teleportar(int head, int tail)
        {
            this.head = head;
            this.tail = tail;
        }

        /// <summary>
        /// Abstract method to change player
        /// </summary>
        /// <param name="p">Player object to take turns</param>
        public abstract  void MovePlayer(Player p);

    }
}