using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;
using SnakesLadder.Persistance.Repository;

namespace SnakesLadder.UnitTest
{
    //Test Class
   public class BoardPositionTest
    {
        //Test method
        [Fact]
        public void Find_BoardPosition()
        {
            //Arrange
            const int num = 5;
            BoardPosition Boardsquare = new BoardPosition(num) ;

            Boardsquare.SetNumber(num);
            //Act
            var expected = num;
             var actual =   Boardsquare.GetNumber();

            //Assert
            Assert.Equal(expected, actual);
        }
            
        
    }
}
