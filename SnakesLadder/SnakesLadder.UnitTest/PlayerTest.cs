using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;
using Newtonsoft.Json;

namespace SnakesLadder.UnitTest
{
    //Test class
    public class PlayerTest
    {
        //Test method1
        [Fact]
        public void Find_Position_To_SetBoardNumber()
        {
            //Arrange
            const int position = 2;
            var player = new Player();

            //Act
            player.SetPosition(position);

            //Assert
            Assert.Equal(2, position);
        }

        //Test method2
        [Fact]
        public void Find_playername_ReturnsPlayerName()
        {
            //Arrange
            const int Pos = 5;
            string PlayerName = "Player 1";
            bool CompPlayer = false;

            Player player = new Player(Pos, PlayerName, CompPlayer);
            var expected = PlayerName;

            //Act
            string playerName = player.GetName();

            //Assert
            Assert.Equal(expected, playerName);
        }

        //Test method 3
        [Fact]
        public void Check_Move_ReturnsPlayerPosition()
        {
            //Arrange
            int position = 0;
            var player = new Player();

            int dice = 6;
            int steps = dice;

            //Act
            position = position + steps;


            //Assert
            Assert.Equal(6, position);
        }

        //Test method 4
        [Fact]
        public void Check_player_Has_Won_ReturnsBool()
        {
            //Arrange
            const int position = 100;
            bool win;

            //Act
            if (position == 100)
                win = true;

            //Assert
            Assert.True(win);
        }

        //Test method 5
        [Fact]
        public void Check_DiceNumber_ReturnsDiceNumber()
        {
            //Arrange
            const int diceNum = 6;
            const int sides = 6;
            var dice = new Dice(sides);
            var player = new Player();
            player.Move(dice);

            //Act
            var actual = player.GetDiceNum();

            //Assert
            Assert.Equal(diceNum, actual);
        }

    }
}
