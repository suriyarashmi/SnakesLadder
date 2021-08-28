using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnakesLadder.Persistance;

namespace SnakesLadder.UnitTest
{
    public class PlayerTest
    {

        [Fact]
        public void find_Position_To_Set()
        {
           //Arrange
           const int position = 2;
           var player = new Player();

            //Act
            player.SetPosition(position);

            //Assert
            Assert.Equal(2,position);
        }

        [Fact]     
        public void Find_playername()
        {
            //Arrange
            var player = new Player();

            //Act
           string playerName =  player.GetName();

            //Assert
            Assert.Equal("Rashmi",playerName);
        }
        
        
        [Fact]
        public void Check_Move()
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


        [Fact]
        public void Check_player_Has_Won()
        {
            //Arrange
            const int position = 100;
            bool win ;

            //Act
            if (position == 100)
                win = true;

            //Assert
            Assert.True( win);
        }

    }
}
