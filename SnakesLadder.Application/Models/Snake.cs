namespace SnakesLadder.Application.Models
{
   public class Snake
    {
        public Snake(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; }
        public int End { get; }
    }
}