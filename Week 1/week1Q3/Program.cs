using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string higher;
            Console.WriteLine("what level are you:"higher||ordinary);
            Console.WriteLine("what is the percentage");
            result = Console.ReadLine();

            int userInput = int.Parse(result);
            int points = 0;

            if (userInput >= 90)
            {
                points = 100;
            }
            else if (userInput >= 80)
            {
                points = 88;
            }
            else if (userInput >= 70)
            {
                points = 77;
            }
            else if (userInput >= 60)
            {
                points = 66;
            }
            else if (userInput >= 50)
            {
                points = 56;
            }
            else if (userInput >= 40)
            {
                points = 46;
            }
            else if (userInput >= 30)
            {
                points = 37;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine($"you entered {userInput}" + $", points for that >>{points}");
            Console.ReadLine();

            if (level<higher)

        }
    }
}
