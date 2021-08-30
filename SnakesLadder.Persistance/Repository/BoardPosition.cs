using SnakesLadder.Persistance.Abstract;
using System;

namespace SnakesLadder.Persistance.Repository
{
    ///<summary>
    /// The class that represents a tile/square on the game board
    ///</summary>
    public class BoardPosition
    {
        private int number; //boardsquare number
        private Teleportar isSnake, isLadder;

        /// <summary>
        /// BoardPosition class constructor
        /// </summary>
        /// <param name="num">Tile/Square number</param>
        public BoardPosition(int num)
        {
            this.number = num;
            this.isSnake = this.isLadder = null;
        }

        /// <summary>
        /// Method to change the tile/square number
        /// </summary>
        /// <param name="num">New tile/square position</param>
        public void SetNumber(int num)
        {
            this.number = num;
        }

        /// <summary>
        /// Method to replace the existing snake teleporter on the tile/square
        /// </summary>
        /// <param name="isSnake">New snake teleporter</param>
        public void SetIsSnake(Teleportar isSnake)
        {
            this.isSnake = isSnake;
        }

        /// <summary>
        /// Method to replace the ladder teleporter that is on the tile/square
        /// </summary>
        /// <param name="isLadder">New ladder teleporter</param>
        public void SetIsLadder(Teleportar isLadder)
        {
            this.isLadder = isLadder;
        }

        /// <summary>
        /// Method to return tile/square number
        /// </summary>
        /// <returns>number of tiles/square</returns>
        public int GetNumber()
        {
            return this.number;
        }


        /// <summary>
        /// Method to return the existing snake teleporter
        /// </summary>
        /// <returns>snake teleporter</returns>
        public Teleportar IsSnake()
        {
            return this.isSnake;
        }

        /// <summary>
        /// Method to return the existing ladder teleporter
        /// </summary>
        /// <returns>teleporter ladder</returns>
        public Teleportar IsLadder()
        {
            return this.isLadder;
        }

        ///<summary>
        /// Method to return the existing ladder teleporter
        /// </summary>
        /// <returns>teleporter ladder</returns>        
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

    
