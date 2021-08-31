using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;

namespace SnakesLadder.UnitTest
{
    //Test class
  public class DiceTest
    {
        //Test method
        [Theory]
        [InlineData(6)]
        public void RollDice_ReturnsRandomValue(int sides)
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
