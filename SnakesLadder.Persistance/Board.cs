using SnakesLadder.Persistance.Repository;
using System;
using SnakesLadder.Persistance.Models;
namespace SnakesLadder.Persistance
{
    public class Board
    {
        //Fields List
        private BoardPosition[] boardPosition;
        private Snake[] snakeSet;
        private Ladder[] ladderSet;

        //Properties
        public Snake[] Snakes
        {
            get
            {
                return snakeSet;
            }
            set
            {
                snakeSet = value;
            }
        }

        public Ladder[] Ladders
        {
            get
            {
                return ladderSet;
            }
            set
            {
                ladderSet = value;
            }
        }

        //Initialisaton 
        //constructor        
        public Board()
        {
            this.boardPosition = new BoardPosition[100];
            for (int i = 0; i < boardPosition.Length; i++)
            {
                boardPosition[i] = new BoardPosition(i);
            }
            snakeSet = new Snake[8];
            ladderSet = new Ladder[8];
            GenerateBoard();
        }

        ///<summary>
        /// Method for generating board
        ///This method determines the position of the snake and ladder on the board
        ///</summary>
        public void GenerateBoard()
        {
            Random r = new Random();
            int count = 0;
            int start = 0;
            int end = 0;
            while (count < 8) //ladder total 8
            {
                start = r.Next(1, 100);
                end = r.Next(1, 100);
                if ((start < end) && IsValidSnakeLadder(boardPosition[start], boardPosition[end]))
                {
                    Ladder l = new Ladder(end, start);
                    boardPosition[start].SetIsLadder(l);
                    boardPosition[end].SetIsLadder(l);
                    ladderSet[count] = l;
                    count++;
                }
            }
            count = start = end = 0;
            while (count < 8) //snake total 8
            {
                start = r.Next(1, 100);
                end = r.Next(1, 100);
                if ((start > end) && IsValidSnakeLadder(boardPosition[start], boardPosition[end]))
                {
                    Snake s = new Snake(start, end);
                    boardPosition[start].SetIsSnake(s);
                    boardPosition[end].SetIsSnake(s);
                    snakeSet[count] = s;
                    count++;
                }
            }

        }


        ///<summary>
        /// This method returns true if the snake or ladder does not exist in t1 and t2
        /// false if the snake or ladder already exists in t1 and t2
        /// </summary>
        /// <param name="t1"> tile to check</param>
        /// <param name="t2"> tile to check</param>
        /// <returns>true if there is no snake or ladder, false if there is a snake or ladder</returns>
        private static bool IsValidSnakeLadder(BoardPosition t1, BoardPosition t2)
        {
            if (t1.GetSnakeLadder() != null || t2.GetSnakeLadder() != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method to get all tiles on the board.
        /// </summary>
        /// <returns>All squares/tile</returns>
        public BoardPosition GetTile(int num)
        {
            return boardPosition[num];
        }

        /// <summary>
        /// Method to get a tile with a specified number
        /// </summary>
        /// <param name="num">Index of the tile to return</param>
        /// <returns>grid with specified number</return
        private BoardPosition[] GetTiles()
        {
            return boardPosition;
        }
    }
}
