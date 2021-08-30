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
        Board b = new Board();
        Dice d = new Dice();


        //Test Method
        [Theory]
        [InlineData(1,1,null, null,null,null,2)]
        public void start_game(int GAME_TYPE1, int turn, Board b, Dice d, Player[] players, Player winner, int totalPlayer)
        {
            
            //Arrange            
            var Turn = new Game();

            //Act
           var actual =  Turn.GetCurrentTurn();

            //Assert
            Assert.Equal(turn, actual);
        }

    }
}
