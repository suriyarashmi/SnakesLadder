using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;

namespace SnakesLadder.UnitTest
{
    public class BoardTest
    {        
        [Fact]        
        public void board_Position_ReturnsTileNumber()
        {
            //Arrange 
            const int num = 5;                     
            var board = new Board();

            //Act
            var expected = (true, 5);
         var actual = (true, board.GetTile(num));

            //Assert
            Assert.Equal(expected.Item1, actual.Item1);
        }


    }
}
