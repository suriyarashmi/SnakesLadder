using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesandLadder.Persistance
{
    class Player
    {
        private int position;
        private string name;
        private bool isComp;
        private int diceNum;
        private bool win;

        public void SetPosition(int position)
        {
            this.position = position;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Move(Dice d)
        {
            int steps = d.RollDice();
            diceNum = steps;
            position = position + steps;
            if (this.position > 99)
            {
                //jika melebihi dari finish
                int pos = this.position - 99;
                this.position = 99 - pos;
            }

        }

        public int GetDiceNum()
        {
            return this.diceNum;
        }

        public int GetPosition()
        {
            return this.position;
        }

        public bool IsWin()
        {
            if (this.position == 99)
            {
                //During finish
                this.win = true;
            }
            return this.win;
        }

        public bool IsCompPlayer()
        {
            return isComp;
        }


    }
}
