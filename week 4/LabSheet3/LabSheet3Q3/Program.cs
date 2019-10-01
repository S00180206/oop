using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("45682012", "Tom Smith", 1000);
            BankAccount acc2 = new BankAccount("75587891", "Mary Mills", 2000);

            Console.WriteLine(acc1.GetAmountDetails());
            Console.WriteLine(acc2.GetAmountDetails());

            Console.WriteLine("Adding $1000");
        }
    }
}
