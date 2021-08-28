using SnakesLadder.Persistance.Abstract;
using SnakesLadder.Application.Models;
using System;

namespace SnakesLadder.Persistance.Repository
{
    public class BoardPosition
    {
        private int number; //board number
        private Teleportar isSnake, isLadder;


        public BoardPosition(int num)
        {
            this.number = num;
            this.isSnake = this.isLadder = null;
        }

        public void SetNumber(int num)
        {
            this.number = num;
        }


        public void SetIsSnake(Teleportar isSnake)
        {
            this.isSnake = isSnake;
        }


        public void SetIsLadder(Teleportar isLadder)
        {
            this.isLadder = isLadder;
        }


        public int GetNumber()
        {
            return this.number;
        }


        public Teleportar IsSnake()
        {
            return this.isSnake;
        }


        public Teleportar IsLadder()
        {
            return this.isLadder;
        }


        public Teleportar GetSnakeLadder()
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

    
