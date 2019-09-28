using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet2
{
    class Program
    {
        static void Main(string[] args)
        {


            ValidateAge();

            
        }
        static void ValidateAge()
        {
            bool ofAge = false;

            Console.WriteLine("Enter your age>>");
            string input = Console.ReadLine();
            int age = int.Parse(input);


            if (age >= 18 && age <= 21)
                ofAge = true;

            if (ofAge == true)
            {
                Console.WriteLine("You can access the site");
            }
            else
            {
                Console.WriteLine("sorry you can't access the site");
            }
        }
    }
}
