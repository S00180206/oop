using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for grade
            Console.WriteLine("please input your result");

            //logic to figure out points
            int points = 0;
            string responce = Console.ReadLine().ToLower();
            
            switch (responce)
            {
                
                case "h1":
                    points=100;
                    break;
                case "h2":
                    points = 88;
                    break;
                case "h3":
                    points = 77;
                    break;
                case "h4":
                    points = 66;
                    break;
                case "h5":
                    points = 56;
                    break;
                case "h6":
                    points = 46;
                    break;
                case "h7":
                    points = 37;
                    break;
                
                default:
                    points = 0;
                    break;
            }

            Console.ReadLine();
        }
    }
}
