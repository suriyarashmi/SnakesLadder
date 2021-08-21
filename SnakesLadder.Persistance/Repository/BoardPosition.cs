using System;

namespace SnakesandLadder.Persistance.Repository
{
    public class BoardPosition
    {
        private int number; //board number
        private Teleporter isSnake, isLadder;


        public BoardPosition(int num)
        {
            this.number = num;
            this.isSnake = this.isLadder = null;
        }

        public void SetNumber(int num)
        {
            this.number = num;
        }


        public void SetIsSnake(Teleporter isSnake)
        {
            this.isSnake = isSnake;
        }


        public void SetIsLadder(Teleporter isLadder)
        {
            this.isLadder = isLadder;
        }


        public int GetNumber()
        {
            return this.number;
        }


        public Teleporter IsSnake()
        {
            return this.isSnake;
        }


        public Teleporter IsLadder()
        {
            return this.isLadder;
        }


        public Teleporter GetSnakeLadder()
        {
            if (isSnake != null)
            {
                return isSnake;
            }
            else if (isLadder != null)
            {
                return isLadder;
            }
            else
            {
                return null;
            }
        }
    }
}

    
