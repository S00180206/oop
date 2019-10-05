using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister();
            Console.WriteLine("Adding an item Worth 2.70 to the Cash Register 1");
            Console.WriteLine("Adding an item Worth 3.45 to the Cash Register 1");
            Console.WriteLine("Adding an item Worth 5.97 to the Cash Register 1");
            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(5.97);

            CashRegister cr2 = new CashRegister();
            Console.WriteLine("Adding an item Worth 12.52 to the Cash Register 2");
            Console.WriteLine("Adding an item Worth 1.43 to the Cash Register 2");
            Console.WriteLine("Adding an item Worth 15.57 to the Cash Register 2");
            Console.WriteLine("Adding an item Worth 5.15 to the Cash Register 2");
            cr2.AddItem(12.52);
            cr2.AddItem(1.43);
            cr2.AddItem(15.57);
            cr2.AddItem(5.15);

            Console.WriteLine("Cash Register CR1 Total:{0}", cr1.Total);
            Console.WriteLine("Cash Register CR1 Number Of Items: {0}",cr1.NumberOfItems);
            Console.WriteLine("Cash Register CR2 Total:{0}", cr2.Total);
            Console.WriteLine("Cash Register CR2 Number Of Items: {0}", cr2.NumberOfItems);
        }
    }
}
