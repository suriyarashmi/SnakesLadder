using SnakesLadder.Persistance.Abstract;

namespace SnakesLadder.Persistance.Models
{ /// <summary>
  /// This class is derived from the Teleporter class
  /// This class represents snake
  /// </summary>
  /// <summary>
    public class Snake : Teleportar
    {       
        /// Constructor
        /// </summary>
        /// <param name="head"> snake head position</param>
        /// <param name="tail"> snake tail position</param>
        public Snake(int head, int tail) : base (head, tail)
        {
            
        }
        /// <summary>
        /// Method override to move player
        /// </summary>
        /// <param name="p"> Player you want to change</param>
        public override void MovePlayer(Player p)
        {
            //set player position on tail
            p.SetPosition(Tail);
        }
    }
}