using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q4
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }

        public Double Total { get; private set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;
        }
    }
}
