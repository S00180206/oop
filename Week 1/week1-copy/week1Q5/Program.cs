using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;

            Console.WriteLine($"please enter a mark, or -1 to quit >>");
            string mark = Console.ReadLine();
            int result = Convert.ToInt32(mark);

            while (result !=-1)
            {
                Console.WriteLine("is it Higher or Ordinary, use h or o>>");
                string level = Console.ReadLine();
                bool higher = false;
                if (level.Equals("h"))
                    higher = true;

                int points;

                if (result >= 90)
                    points =higher ? 100:56;
                    
                else if (result >= 80)
                    points = higher ? 88 : 46;
                else if (result >= 70)
                    points = higher ? 77 : 37;
                else if (result >= 60)
                    points = higher ? 66 : 28;
                else if (result >= 50)
                    points = higher ? 56 : 20;
                else if (result >= 40)
                    points = higher ? 46 : 12;
                else if (result >= 30)
                    points = higher ? 37 : 0;
                else
                    points = 0;

                totalPoints += points;

                Console.WriteLine($"please enter a mark, or -1 to quit>>");
                mark = Console.ReadLine();
                result = Convert.ToInt32(mark);

            }
            Console.WriteLine($"the total points are {totalPoints}");
            Console.ReadLine();
            
        }
    }
}
