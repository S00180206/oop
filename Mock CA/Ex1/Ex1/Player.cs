using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game

{
    public class Player :IComparable
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

        public override string ToString()
        {
            return $"{ID}\t{PlayerName}\t{Score}";
        }

        public int CompareTo(object obj)
        {
            //get a refrence to the next object in the list/array/collection
            Player objectThatIAmComparingTo = (Player)obj;//or obj as Player;//something to compare our current object to


            //indicate what field I want ro compare
            int returnValue = this.Score.CompareTo(objectThatIAmComparingTo.Score);

            //return
            return returnValue;
        }
    }
}
