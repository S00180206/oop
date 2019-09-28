using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week1Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\temp\results.txt";
            string[] fileContents = File.ReadAllLines(filePath);

            //method calculate
            int totalPoints = CalculatePoints(fileContents);

            //output to screen
            Console.WriteLine($"total points are {totalPoints}");

            //pause
            Console.ReadLine();
        }

        private static int CalculatePoints(string[] data)
        {
            int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
            int[] higherPoints = new int[8] { 100, 88, 76, 66, 56, 46, 37, 0 };

            //total
            int totalPoints = 0, points = 0, result = 0;

            for (int i=0; i <data.Length; i++)
            {
                result = Convert.ToInt32(data[i]);

                //loop trough boundaries
                for (int j=0; j<gradeBoundaries.Length; j++)
                {
                    if (result>=gradeBoundaries[j])
                    {
                        points = higherPoints[j];
                        break;
                    }
                }
                totalPoints += points;
            }
            return totalPoints;
        }
    }
}
