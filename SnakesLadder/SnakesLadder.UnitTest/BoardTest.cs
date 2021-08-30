using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;

namespace SnakesLadder.UnitTest
{
    public class BoardTest
    {
        [Theory]
        [InlineData(5)]
        public void board_Position_check(int num)
        {
            //Arrange          
            var board = new Board();

            //Act
            var expected = (true, 5);
         var actual = (true, board.GetTile(num));

            //Assert
            Assert.Equal(expected.Item1, actual.Item1);
        }


    }
}
