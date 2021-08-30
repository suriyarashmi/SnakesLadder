using System;

namespace SnakesLadder.Persistance
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

        //generate random number by rolling dice
        public int RollDice()
        {
            Random r = new Random();
            int dices = r.Next(1, 7);
            return dices;
        }
    }
}