using SnakesLadder.Persistance;
using SnakesLadder.Persistance.Models;
using SnakesLadder.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using UI;
using Xunit;

namespace SnakesLadder.AcceptanceTest
{
    //Test Class
    public class PlayGameTest
    {
        //Test method
       [Fact]
        public static void  Main ()
        {
            //Arrange
            var game = new Game();
            Player[] players = { new Player(100, "Player 1", false), new Player(1, "Player 2", true) };

            while (game.GetWinner() == null)
            {
                Player current = game.GetCurrentPlayer();
                game.RunGame();
                var expected = "Player 1";

                //Act
                var actual = game.GetWinner().ToString();

                //Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}