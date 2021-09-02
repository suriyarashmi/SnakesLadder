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
            //Arrange
            const int Pos = 5;
            string PlayerName = "Player 1";
            bool CompPlayer = false;

            Board b = new Board();
            Dice d = new Dice();
            Player[] players = { new Player(1,"Player 1", false), new Player(0,"Player 2", true) };

            Player player = new Player(Pos, PlayerName, CompPlayer);
            var expected = PlayerName;
                     
           var game =  new Game(b,players,d);
            //Act
            var actual = game.GetWinner().ToString();

            //Assert
            Assert.Equal(expected.ToString(), actual);
        }

        //Test Method2
        [Fact]        
        public void Find_PlayerTurn_ReturnsTurnNumber()
        {
            //Arrange
            const int turn = 1;
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
            const int Pos = 100;
            string PlayerName = "Player 1";
            bool CompPlayer = false;
            Player player = new Player(Pos, PlayerName, CompPlayer);
            var expected = PlayerName;
            var game = new Game();

            //Act
            var actual = game.GetWinnerInformation();

            //Assert
            Assert.Equal(expected,actual);
        }





    }
}
