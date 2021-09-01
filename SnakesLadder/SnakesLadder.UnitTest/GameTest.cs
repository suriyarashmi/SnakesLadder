using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;
using Moq;
using Autofac.Extras.Moq;

namespace SnakesLadder.UnitTest
{
    //Test Class
    public class GameTest
    {
        //Test Method1 
        [Fact]
        public void check_winner_ReturnsWinnerName()
            
        {
            Mock<Player> player = new Mock<Player>();
            var expected = player.Name;
            //Arrange            
            var game = new Game();

            //Act
            var actual = game.GetWinner().ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        //Test Method2
        [Theory]
        [InlineData(1)]
        public void Find_PlayerTurn_ReturnsTurnNumber( int turn)
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
        public void Check_WinnerName_ReturnsWinnerName()
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
