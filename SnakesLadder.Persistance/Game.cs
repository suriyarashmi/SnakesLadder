using SnakesLadder.Persistance;
using SnakesLadder.Persistance.Abstract;
using SnakesLadder.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadder.Persistance
{
    public class Game 
    {
        private const int GAME_TYPE1 = 1;//vs Human

        private const int GAME_TYPE2 = 2;//vs Computer

        private int playingTurn;//players Turn


        private Board board; //game board
        private Player[] players; // An attribute that stores the number of players in the game    
        private Player winner; // Player who wins the game
        private Dice dice; // Attribute for dice
        private int totalPlayer; // total number of players 

        public Board B { get; }
        public Dice D { get; }

        ///<summary>
        /// Constructor.
        ///</summary>
        /// <param name="b">board object</param>
        /// <param name="d">dice object</param>
        /// <param name="gameType">game type</param>
        public Game(Board b, Dice d, int gameType)
        {
            this.dice = d;
            this.board = b;
            if (gameType == GAME_TYPE1)
            {
                players = new Player[] { new Player(0, "Player 1", true), new Player(0, "Player 2", false) };
            }
            else
            {
                players = new Player[] { new Player(0, "Player 1", false), new Player(0, "Computer", true) };
            }
            this.winner = null;
            this.totalPlayer = players.Length;
            this.playingTurn = 0;
        }

        public Game(Board b, Player[] players, Dice d)
        {
            B = b;
            this.players = players;
            D = d;
        }

        public Game()
        {
        }
        ///<summary>
        /// Method to run snake and ladder game.
        ///</summary>
        public void RunGame()
        {
            // check player's position on board to move by rolling the dice
            //and determine the new position.
            players[playingTurn].Move(this.dice);
            int pos = players[playingTurn].GetPosition();

            //check the player in that position
            // find ladder or snake.
            Teleportar snakeLadder = board.GetTile(pos).GetSnakeLadder();
            if (snakeLadder != null)
            {
                snakeLadder.MovePlayer(players[playingTurn]);
            }

            //check every player's move,
            //find whether he has reached the finish
            if (players[playingTurn].IsWin())
            {
                SetWinner(players[playingTurn]);
            }

            // it's another player's turn
            if (players[playingTurn].GetDiceNum() != 6)
            {
                playingTurn = playingTurn + 1;

                //after everyone has had a turn to play,
                //returned to the first turn.
                if (playingTurn == this.totalPlayer)
                {
                    playingTurn = 0;
                }
                if (players[playingTurn].IsCompPlayer())
                {
                    RunGame();
                }
            }
        }

        /// <summary>
        /// Method to determine the winner.
        /// </summary>
        /// <param name="p">winning player</param>
        public void SetWinner(Player p)
        {
            this.winner = p;
        }

        /// <summary>
        /// Getters for the winner attribute
        /// </summary>
        /// <returns>winners</returns>
        public Player GetWinner()
        {
            return winner;
        }

        /// <summary>
        /// Returns the current player
        /// </summary>
        /// <returns>players currently playing</returns>
        public Player GetCurrentPlayer()
        {
            return players[playingTurn];
        }

        /// <summary>
        /// Returns the winner's name information.
        /// </summary>
        /// <returns>Winner's name</returns>
        public string GetWinnerInformation()
        {
            return this.winner.GetName();
        }


        /// <summary>
        /// Method to return player's turn
        /// </summary>
        /// <returns>Player's Turn</returns>
        public int GetCurrentTurn()
        {
            return this.playingTurn;
        }

        /// <summary>
        /// Method to get a player whose turn
        /// </summary>
        /// <param name="turn">Player's turn</param>
        /// <returns>Player whose turn</returns>
        public Player GetPlayerAtTurn(int turn)
        {
            return players[turn];
        }

    }
    


}
