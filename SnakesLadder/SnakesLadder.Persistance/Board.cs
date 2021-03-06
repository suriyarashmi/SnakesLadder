using System;

namespace SnakesandLadder.Persistance
{
    public class Board
    {
        //Properties List
        private BoardPosition[] boardPosition;
        private Snake[] snakeSet;
        private Ladder[] ladderSet;


        //Initialisaton

        //method
        public Board()
        {
            this.boardPosition = new BoardPosition[100];
            for (int i = 0; i <boardPosition.Length; i++)
            {
                boardPosition[i] = new BoardPosition(i);
            }
            snakeSet = new Snake[8];
            ladderSet = new Ladder[8];
            GenerateBoard();
        }


        private void GenerateBoard()
        {
            Random r = new Random();
            int count = 0;
            int start = 0;
            int end = 0;
            while (count < 8)
            {
                start = r.Next(2, 99);
                end = r.Next(2, 99);
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
            while (count < 8)
            {
                start = r.Next(2, 99);
                end = r.Next(2, 99);
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
        private bool IsValidSnakeLadder(BoardPosition t1, BoardPosition t2)
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

    }
}
