using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_CA1
{
    class Program
    {
        static void Main(string[] args)
        {

            //setup
            Console.OutputEncoding = ASCIIEncoding.UTF8; //allows euro symbol
            

            decimal totalAllFittings=0, totalCost;
            int numberOfFittings=0;
            string repeat;
            do
            {
                //userinput
                totalCost = CalculateFittingCost(ref totalAllFittings, ref numberOfFittings);//values are passed by reference
                
                Console.Write("please enter 0 to quit and 1 to enter more values");
                repeat = Console.ReadLine();
            }
            while (repeat.Equals("1"));

            //output
            DisplayOutput(totalAllFittings, numberOfFittings);

            Console.ReadLine();

        }//end of main

        //displays total and average values
         static void DisplayOutput(decimal totalAllFittings, int numberOfFittings)
        {
            Console.WriteLine("total cost of all fittings: {0:C}",totalAllFittings);
            Console.WriteLine("average cost of fitting: {0:C}", totalAllFittings/numberOfFittings);
        }//end of the method displayOutut

        //calculate the costs of fitting carpet including discount
        static decimal CalculateFittingCost(ref decimal totalAllFittings, ref int numberOfFittings)
        {
            //setup
            const decimal COST_PER_KM = 0.45M;
            const decimal COST_PER_METER = 3.25M;

            string input1, input2;
            int distance, carpetSize;
            decimal totalCost;

            Console.Write("please enter distence to fitting >>");
            input1 = Console.ReadLine();
            distance = Convert.ToInt32(input1);

            Console.WriteLine("please enter the size of the carpet >>");
            input2 = Console.ReadLine();
            carpetSize = Convert.ToInt32(input2);


            //calculation
            totalCost = (COST_PER_KM * distance) + (COST_PER_METER * carpetSize);

            //apply discount 10% if over 250
            if (totalCost > 250)
                totalCost *= 0.9m;

            //udate totals
            totalAllFittings += totalCost;
            numberOfFittings++;

            return totalCost;
        }//end of method calculatefittingcost
    }
}
