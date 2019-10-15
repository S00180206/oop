using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
    public abstract class Game
    {
        #region Properties

        //public string Name{get; set;}

        private readonly string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        private decimal 

        public Game(string name, decimal price, DataTime releasedate)
        {
            _name = name;
            Price = price;
            releasedate = releasedate;

        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {

        }

        public Game() : this("", 0) { }

        #endregion Constructors
    }
    public ComputerGame : Game
        {
            public string PEGI_Rating { set; get; }

            public ComputerGame(string name, decimal price, DateTime date, string pegi)
                 : base(name, price, date)
                {
                     PEGI_Rating = pegi;
                }
        }
    public decimal GetDiscountPrice()
{
    return Price * .9m;
}

}
