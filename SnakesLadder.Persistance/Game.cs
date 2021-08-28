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


        private Board board;
        private Player[] players;
        private Player winner;
        private Dice dice;
        private int totalPlayer;

        public Board B { get; }
        public Dice D { get; }

        public Game(Board b, Dice d, int gameType)
        {
            this.dice = d;
            this.board = b;
            if (gameType == GAME_TYPE1)
            {
                players = new Player[] { new Player(0, "Player 1", false), new Player(0, "Player 2", false) };
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

        public void RunTheGame()
        {

            players[playingTurn].Move(this.dice);
            int pos = players[playingTurn].GetPosition();

   Teleportar snakeLadder = (Teleportar)board.GetTile(pos);
            if (snakeLadder != null)
            {
                snakeLadder.MovePlayer(players[playingTurn]);
            }


            if (players[playingTurn].IsWin())
            {
                SetWinner(players[playingTurn]);
            }


            if (players[playingTurn].GetDiceNum() != 6)
            {
                playingTurn = playingTurn + 1;

                if (playingTurn == this.totalPlayer)
                {
                    playingTurn = 0;
                }
                if (players[playingTurn].IsCompPlayer())
                {
                    RunTheGame();
                }
            }
        }
        public void SetWinner(Player p)
        {
            this.winner = p;
        }
        public Player GetWinner()
        {
            return winner;
        }


        public Player GetCurrentPlayer()
        {
            return players[playingTurn];
        }


        public string GetWinnerInformation()
        {
            return this.winner.GetName();
        }



        public int GetCurrentTurn()
        {
            return this.playingTurn;
        }


        public Player GetPlayerAtTurn(int turn)
        {
            return players[turn];
        }

    }
    


}
