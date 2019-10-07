using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4
{

    public class Team
    {
        public string Name { get; private set; }

        public int Wins { get; private set; }

        public int Draws { get; private set; }

        public int Losses { get; private set; }

        public int Played { get; private set; }

        private int points;

        public int Points
        {
            get
            {
                points =(Wins * 3)+(Draws * 1);
                return points;
            }
        }





        public Team(string name)
        {
            Name = name;
            //Players = new List<Player>();
        }


        public string DisplayTeamTable()
        {
            return string.Format($"{Name,-15}{Points,-7}{Wins,-7}{Draws,-7}{Losses,-7}{Played,-7}");
        }

    }
    
}
