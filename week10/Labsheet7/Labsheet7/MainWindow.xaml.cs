using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Expense> expenses;
        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        //this method will run when the window loads- on startup
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create 3 expense boxes
            Expense e1 = GetRandomExpense();/*new Expense() { Category = "Travel", Amount = 19.95m, ExpenseDate = new DateTime(2019, 6, 30) };*/

            Expense e2 = GetRandomExpense();/*new Expense() { Category = "Entertainment", Amount = 99.95m, ExpenseDate = new DateTime(2019, 7, 30) };*/

            Expense e3 = GetRandomExpense();/*new Expense() { Category = "Office", Amount = 9.99m, ExpenseDate = new DateTime(2019, 6, 25) };*/

            //add those to a list
            expenses = new ObservableCollection<Expense>();// new list on window load
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            //display list ib listbox
            lbxExpenses.ItemsSource=expenses;

            tblkTotal.Text = Expense.TotalExpenses.ToString();
        }//end of winfdow method

        //method to add expense item
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ////create an expense
            //Expense e1 = new Expense()
            //{
            //    Category = "Travel",
            //    Amount = 55.45m,
            //    ExpenseDate = DateTime.Now
            //};

            //add that to the list
            expenses.Add(GetRandomExpense());

            tblkTotal.Text = Expense.TotalExpenses.ToString("C");

            //refresh screen
            //lbxExpenses.ItemsSource = null;
            //lbxExpenses.ItemsSource = expenses;
        }

        private Expense GetRandomExpense()
        {
            //get random category
            string[] categories = { "Category", "Travel", "Entertainment" };
            int randomNumber = rng.Next(0, 3);//0,1 0r 2
            string category = categories[randomNumber];

            //get random account
            randomNumber = rng.Next(1, 10001);
            decimal randomAmount = (decimal)randomNumber / 100;

            //get random date - in the last 30 days 
            randomNumber = rng.Next(0, 31);//0--30
            DateTime randomDate = DateTime.Now.AddDays(-randomNumber);//give me a date in the last 30 days

            //create the expense object with random info 
            Expense e1 = new Expense(randomAmount, randomDate, category);

            //return random object 
            return e1;
        }



    }
}
