using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet7
{
    public class Expense
    {

        //properties
        //public decimal Amount { get; set; }
        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                TotalExpenses += value;
                _amount = value;
            }
        }

        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }

        public static decimal TotalExpenses;

        //constructors-return later to link with this 
        public Expense():this(0, DateTime.Now,"Unknown"){}

        public Expense(decimal amount, DateTime date, string category)
        {
            Amount = amount;
            ExpenseDate = date;
            Category = category;
        }
        //methods
        public override string ToString()
        {
            return $"{Category}{Amount:C} on {ExpenseDate.ToShortDateString()}";
        }

    }
}
