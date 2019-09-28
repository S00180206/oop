using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week1Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name>>");
            string name = Console.ReadLine();

            Console.WriteLine("enter ID>>");
            string ID = Console.ReadLine();

            string[] subjects = new string[7];
            string[] levels = new string[7];
            string[] results = new string[7];
            int[] points = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"subject name{i + 1}>>");
                subjects[i] = Console.ReadLine();

                Console.WriteLine($"subject level for {subjects[1]}>>");
                levels[i] = Console.ReadLine();

                Console.WriteLine($"subject result for {subjects[1]}>>");
                results[i] = Console.ReadLine();
            }

            int totalPoints = CalculatePoints(results, levels, points);

            DisplayResults(name, ID, subjects, results, levels, points, totalPoints);

            WriteDetailsToFile(name, ID, subjects, results, levels, points, totalPoints);

            Console.ReadLine();

        }
        private static void WriteDetailsToFile(string name, string ID, string[] subjects, string[] results, string[] levels, int[] points, totalPoints);
        {
        private static void DisplayResults(string name, string ID, string[] subjects, string[] results, string[] levels, int[] points, totalPoints);
        {
            Console.WriteLine($"Name:{}");
            Console.WriteLine($"ID:{ID});

            for(int i=0; i< results.Length; i++);
            {
                Console.WriteLine($"{subjects[i]10}{levels[i]10}{results[i]10}{points[i]10});
            }
            Console.WriteLine($"total points:{totalPoints}");
        }
        
       /* private static void calculatePoints(string[] data, string[] levels, int[] studentPoints )
        {
            int[] gradeBoundaries = new int[] { 90, 80, 70, 60, 50, 40, 30, 0 };
            int[] higherPoints = new int[] { 100, 88, 77, 66, 56, 46, 37, 0 };
            int[] ordinaryPoints = new int[] { 56, 46, 37, 28, 20, 12, 0, 0 };

            int totalPoints = 0, points = 0;

            for(int i=0; i<data.Length; i++)
            {
                int result = Convert.ToInt32(data[i]);

                for(int j=0; j<gradeBoundaries.Length; j++)
                {
                    points = levels[i].ToLower().Equals("h") ? higherPoints[j] : ordinaryPoints[j];
                    break;
                }
                studentPoints[i] = points;
            }
            Array.Sort(studentPoints);
            Array.Reverse(studentPoints);

            for (int i = 0; i < 6; i++)
            {
                totalPoints += studentPoints[i];
            }
            return totalPoints;
        }*/
            


    }
}
