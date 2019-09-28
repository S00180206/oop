using System;

namespace LabSheet2Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Products();
        }
        static void Products()
        {
            Console.WriteLine("what product do you require");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Jeans":
                    Console.WriteLine("cost: 67.99");
                    break;

                case "Jacket":
                    Console.WriteLine("cost: 68.99");
                    break;

                case "Boots":
                    Console.WriteLine("cost: 34.99");
                    break;

                case "Scareves":
                case "belts":
                case "Socks":
                    Console.WriteLine("cost: 10");
                    break;

                default: Console.WriteLine("price error: -999");
                    break;

            }
        }
    }
}
