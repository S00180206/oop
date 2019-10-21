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

        }
    }
}
