using System;

namespace SnakesandLadder.Application.Models
{
    public class Dice
    {
        private int sides;

        public Dice(int sides)
        {
            this.sides = sides;
        }
        //Constructor
        public Dice()
        {
            this.sides = 6;
        }

        public int RollDice()
        {
            Random r = new Random();
            int dices = r.Next(1, 7);
            return dices;
        }
    }
}