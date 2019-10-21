using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game

{
    public class Player
    {
        public int ID { get;  }

        public string PlayerName { get; set; }

        public int Score { get; private set; }

        public static int HighScore { get; private set; }


        public Player (int id, string playerName, int score )
        {
            ID = id;
            PlayerName = playerName;
            Score = score;
        }

        public void IncreaceScore(int valueToAdd)
        {
            if (Score < 100)
                Score += valueToAdd;

            //check for high score
            if (Score > HighScore)
                HighScore = Score;
        }

    }
}
