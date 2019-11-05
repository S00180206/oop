using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace week_9_P2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            Rolling();
                
            

            
        }
        public async void Rolling()
        {
        Random rf = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = rf.Next(1, 7);

                tblkNumber.Text = number.ToString();

                await Task.Delay(50);
            }
        }
    }
}
