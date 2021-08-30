using SnakesLadder.Persistance.Abstract;

namespace SnakesLadder.Persistance.Models
{
    /// <summary>
    /// This class is derived from the Teleporter class
    /// This class represents Ladder
    /// </summary>
    public class Ladder : Teleportar
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="head">head ladder position</param>
        /// <param name="tail">tail ladder position</param>
        public Ladder(int head, int tail) : base (head, tail)
        {
          
        }
        ///<summary>
        ///Method override to move player
        ///</summary>
        ///<param name="p">Player to be changed</param>
        public override void MovePlayer(Player p)
        {
            p.SetPosition(Head);
        }
    }
}