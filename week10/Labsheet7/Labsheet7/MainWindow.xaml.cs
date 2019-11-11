using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labsheet7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Expense> expenses; 
        public MainWindow()
        {
            InitializeComponent();
        }

        //this method will run when the window loads- on startup
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create 3 expense boxes
            Expense e1 = new Expense() { Category = "Travel", Amount = 19.95m, ExpenseDate = new DateTime(2019, 6, 30) };
            Expense e2 = new Expense() { Category = "Entertainment", Amount = 99.95m, ExpenseDate = new DateTime(2019, 7, 30) };
            Expense e3 = new Expense() { Category = "Office", Amount = 9.99m, ExpenseDate = new DateTime(2019, 6, 25) };

            //add those to a list
            expenses = new List<Expense>();// new list on window load
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            //display list ib listbox
            lbxExpenses.ItemsSource=expenses;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create an expense
            Expense e1 = new Expense()
            {
                Category = "Travel",
                Amount = 55.45m,
                ExpenseDate = DateTime.Now
            };

            //add that to the list
            expenses.Add(e1);

            //refresh screen
            lbxExpenses.ItemsSource = expenses;
        }
    }
}
