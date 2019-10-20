using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

           // Game g1 = new Game("monopoly", 19.99m, new DateTime(1970, 01, 31));

           // Game g2 = new Game("Scrabble", 9.99m, new DateTime(1980, 06, 30));

            ComputerGame cg1 = new ComputerGame("Sonic", 19.99m, new DateTime(1990, 03, 15), "U");

            ComputerGame cg2 = new ComputerGame("Mario", 10.99m, new DateTime(1995, 11, 17), "7");


           // DisplayGame(g1);
            //DisplayGame(g2);
            DisplayGame(cg1);
            DisplayGame(cg2);

        }
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
