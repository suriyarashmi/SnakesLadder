using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;
using Moq;

namespace SnakesLadder.UnitTest
{
    //Test Class
    public class GameTest
    {
        //Test Method1       
        public void check_winner()
        {
            var player = new Player();
            //Arrange            
            var game = new Game();

            //Act
            var actual = game.GetWinner();

            //Assert
            Assert.Equal(player, actual);
        }

        //Test Method2
        [Theory]
        [InlineData(1)]
        public void Find_PlayerTurn( int turn)
        {            
            //Arrange            
            var game = new Game();

            //Act
           var actual =  game.GetCurrentTurn();

            //Assert
            Assert.Equal(turn, actual);
        }
     
        //Test Method3
        [Fact]
        public void Check_WinnerName()
        {
            //Arrange
            var player = new Player();
            var expected = player.GetName();
            var game = new Game();

            //Act
            var actual = game.GetWinnerInformation();

            //Assert
            Assert.Equal(expected,actual);
        }





    }
}
