using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesandLadder.Application.Interfaces
{
   public interface ITeleportar
    {
        int tail, head;

        void MovePlayer(Player p);
    }
}
