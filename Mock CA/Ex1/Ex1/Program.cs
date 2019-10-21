using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            List<Player> AllPlayers = new List<Player>();
            AllPlayers.Add(player1);
            AllPlayers.Add(player2);
            AllPlayers.Add(player3);
            AllPlayers.Add(player4);
            AllPlayers.Add(player5);

            player1.IncreaceScore(1);
            player2.IncreaceScore(5);

            Display(AllPlayers);
            GetScores(AllPlayers);

        }

        private static void GetScores(List<Player> AllPlayers)
        {
            // loop asking for player number 
            Console.WriteLine("please enter the number of player you wish to add the score for");
            string responce = Console.ReadLine();
            int playerNumber = int.Parse(responce);

            while (playerNumber != 0)
            {
                // determine player selected
                Player selectedPlayer = AllPlayers.ElementAt(playerNumber - 1);//using minus 1 as index starts at zero

                //increase score for that player
                selectedPlayer.IncreaceScore(1);
                //display results
                Display(AllPlayers);

                //ask player or zero to quit
                Console.WriteLine("please enter the number of player you wish to add the score for");
                responce = Console.ReadLine();
                playerNumber = int.Parse(responce);
            }//end
        }

        public static void Display(List<Player>players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player1", "Player2", "Player3", "Player4", "Player5");

            //loop for players and scores

            foreach (Player player in players)
            {
                Console.Write("{0,-10}", player.Score);
            }

            Console.WriteLine();//new line to make it more tidy
        }
    }
}
