using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadder.Persistance
{
public class Player
    {
        private int position;
        private string name;
        private bool isComp;
        private int diceNum;
        private bool win;
        private int pos;
        private string playerName;
        private bool compPlayer;

        public Player(int pos, string playerName, bool compPlayer)
        {
            this.pos = pos;
            this.playerName = playerName;
            this.compPlayer = compPlayer;
        }

        public Player()
        {
        }

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
                //if it exceeds the finish
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
            if (this.position == 100)
            {
                //check finish
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
