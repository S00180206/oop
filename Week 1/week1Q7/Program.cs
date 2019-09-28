using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week1Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file
            string filePath = @"c:\temp\results.txt";
            string[] fileContents = File.ReadAllLines(filePath);

            //total
            int totalPoints = 0, points = 0, result = 0;
            foreach (string s in fileContents)
            {
                result = Convert.ToInt32(fileContents[i]);

                if (result >= 90)
                {
                    points = 100;
                }
                else if (result >= 80)
                {
                    points = 88;
                }
                else if (result >= 70)
                {
                    points = 77;
                }
                else if (result >= 60)
                {
                    points = 66;
                }
                else if (result >= 50)
                {
                    points = 56;
                }
                else if (result >= 40)
                {
                    points = 46;
                }
                else if (result >= 30)
                {
                    points = 37;
                }
                else
                {
                    points = 0;
                }
                totalPoints += points;

            }
    }
}
