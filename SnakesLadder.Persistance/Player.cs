using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadder.Persistance
{
    /// <summary>
    /// This class represents a Player
    /// </summary>
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="position"> player position</param>
        /// <param name="name"> player name</param>
        /// <param name="isComp"> player is computer or not</param>
        public Player(int pos, string playerName, bool compPlayer)
        {
            this.pos = pos;
            this.playerName = playerName;
            this.compPlayer = compPlayer;
        }

        public Player()
        {
        }

        /// <summary>
        /// Position attribute setters
        /// </summary>
        /// <param name="position"> new player position</param>
        public void SetPosition(int position)
        {
            this.position = position;
        }

        /// <summary>
        /// Getter attribute name
        /// </summary>
        /// <returns>player name</returns>
        public string GetName()
        {
            return this.name;
        }


        /// <summary>
        /// Method to run player
        /// </summary>
        /// <param name="d"> Dice object</param>
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
        /// <summary>
        /// Method to return the value of the roll of the dice
        /// </summary>
        /// <returns>Result of rolling the dice</returns>
        public int GetDiceNum()
        {
            return this.diceNum;
        }

        /// <summary>
        /// Position attribute getters
        /// </summary>
        /// <returns>player position</returns>
        public int GetPosition()
        {
            return this.position;
        }

        /// <summary>
        /// Returns the value of the win attribute
        /// </summary>
        /// <returns>true if player's position is at 100, false if not</returns>
        public bool IsWin()
        {
            if (this.position == 100)
            {
                //check game finish
                this.win = true;
            }
            return this.win;
        }

        /// <summary>
        /// Returns the value of the isComp attribute
        /// </summary>
        /// <returns>isComp attribute</returns>
        public bool IsCompPlayer()
        {
            return isComp;
        }


    }
}
