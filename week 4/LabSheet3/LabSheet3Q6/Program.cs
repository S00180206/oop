using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "hot dog";
            lunch1.Drink ="lemon aid";
            lunch1.Food ="chips";

            lunch2.Entree ="pizza" ;
            lunch2.Drink ="salad";
            lunch2.Food ="coke";

            lunch3.Entree = "chicken sandwich";
            lunch3.Drink ="water";
            lunch3.Food ="shepards pie";

            lunch4.Entree = "ceral";
            lunch4.Drink ="orange juice";
            lunch4.Food ="toast";

            lunch5.Entree = "apple pie";
            lunch5.Drink ="fanta";
            lunch5.Food ="snack box";

            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);
        }

        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0, -24 }{1, -12}{2, -10}", "Entree", "Food", "Drink", "Color", "Value");

            foreach(Lunch lunch in lunches )
            {
                Console.WriteLine("{0, -24}{1, -12}{2, -10}", lunch.Entree, lunch.Food, lunch.Drink);
            }
        }
    }
    public class Lunch
    {
        public string Entree { get; set; }
        public string Drink { get; set; }
        public string Food { get; set; }
    }
}
