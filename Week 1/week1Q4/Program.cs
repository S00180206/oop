using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMarks = 0, lowestMarks = 100;
            int result;

            string[] Subjects = new string[] { "Maths", "English", "Geogarphy", "Art", "Construction", "Irish", "Physics" };
            int[] Results = new int[7];
            // int total = 0;


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"enter your mark number {i + 1}>>");
                string mark = Console.ReadLine();
                result = Convert.ToInt32(mark);

                Console.WriteLine("are you higher or ordinary:");
                string level = Console.ReadLine().ToLower();
                bool higher = false;
                if (level.Equals("h"))
                    higher = true;

                int points;
                if (result >= 90)
                    //points = higher > 100 :56;
                    if (higher)
                        points = 100;
                    else
                        points = 56;

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

                totalMarks += points;


                if (points < lowestMarks)
                    lowestMarks = points;


            }
            Console.WriteLine($"your total point are:{totalMarks - lowestMarks}");
            Console.ReadLine();


        }
    }
}
