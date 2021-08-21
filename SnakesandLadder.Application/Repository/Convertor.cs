using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesandLadder.Application.Repository
{
    class Convertor
    {

        //Properties of game piece location
        private int position;
        private int x;
        private int y;

        //Constructor
        public Converter()
        {
            this.x = this.y = -1;
        }

        //Board postion for piece
        public void Convert(int position)
        {
            int tempX = 0;
            int tempY = 0;
            tempY = position / 10;
            if (position % 10 == 0) tempY--;
            this.y = (9 - tempY);

            if (y % 2 == 0)
            {
                if ((position % 10) > 0)
                {
                    tempX = (9 - (position % 10)) + 1;
                }
                this.x = tempX;
            }
            else
            {
                if (position % 10 == 0) x = 9;
                else x = (position % 10) - 1;
            }
        }


        public int GetX()
        {
            return x;
        }


        public int GetY()
        {
            return y;
        }


    }
}