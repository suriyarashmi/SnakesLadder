using System;

namespace SnakesandLadder.Application
{
    public class BoardPosition
    {
        private int number;

        public BoardPosition(int num)
        {
            this.number = num ;
        }
      
        internal object GetSnakeLadder()
        {
            throw new NotImplementedException();
        }

        internal void SetIsSnake(Snake s)
        {
            throw new NotImplementedException();
        }

        internal void SetIsLadder(Ladder l)
        {
            throw new NotImplementedException();
        }
    }
}