using System.Collections.Generic;
using System.Linq;

class BowlingGame
{
    static void Main(string[] args)
    {
        BowlingGame game = new BowlingGame();
    }
}

namespace Program
{
    public class Game
    { 
        List<int> results = new List<int>();
        int sum;

        public void Throw(int pins) {
            results.Add(pins);
        }

        public int Score()
        {
            return 0;
        }
    }
}
