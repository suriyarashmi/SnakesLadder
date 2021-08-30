using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;

namespace SnakesLadder.UnitTest
{
  public class DiceTest
    {
      
        [Theory]
        [InlineData(6)]
        public void RollDice_randomValue(int sides)
        {
            //Arrange
            var dice = new Dice();

            //Act
            var actual = dice.RollDice();

            //Assert
            Assert.Equal(sides, actual);
        }

    }
}
