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

namespace Exam_s00180206
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Player> selectedPlayers = new List<Player>();
            List<Player> allPlayers = new List<Player>();

            #region OrderingPlayers
            Player p1 = new Player("John", "Smith", Player.Position.Goalkeeper);
            Player p2 = new Player("bob", "Jones", Player.Position.Goalkeeper);
            Player p3 = new Player("rick", "Murphy", Player.Position.Defender);
            Player p4 = new Player("micheal", "moore", Player.Position.Defender);
            Player p5 = new Player("sarah", "Roberts", Player.Position.Defender);
            Player p6 = new Player("frank", "Rabbit", Player.Position.Defender);
            Player p7 = new Player("Amanda", "stack", Player.Position.Defender);
            Player p8 = new Player("Glenn", "peterson", Player.Position.Defender);
            Player p9 = new Player("jordan", "johnson", Player.Position.Midfielder);
            Player p10 = new Player("Mary", "Smith", Player.Position.Midfielder);
            Player p11 = new Player("Mary", "Smith", Player.Position.Midfielder);
            Player p12 = new Player("Mary", "Smith", Player.Position.Midfielder);
            Player p13 = new Player("Mary", "Smith", Player.Position.Midfielder);
            Player p14 = new Player("Mary", "Smith", Player.Position.Midfielder);
            Player p15 = new Player("Mary", "Smith", Player.Position.Forwards);
            Player p16 = new Player("Mary", "Smith", Player.Position.Forwards);
            Player p17 = new Player("Mary", "Smith", Player.Position.Forwards);
            Player p18 = new Player("Mary", "Smith", Player.Position.Forwards);

            
            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);
            allPlayers.Add(p9);
            allPlayers.Add(p10);
            allPlayers.Add(p11);
            allPlayers.Add(p12);
            allPlayers.Add(p13);
            allPlayers.Add(p14);
            allPlayers.Add(p15);
            allPlayers.Add(p16);
            allPlayers.Add(p17);
            allPlayers.Add(p18);

            lbAll.ItemsSource = allPlayers;

            /*lbxDetails*///.ItemsSource = allPlayers.OrderBy(s => s.FirstName).ThenBy(s => s.SurName);

            #endregion OrderingPlayers

            string[] Firstnames = { "John", "bob", "rick", "micheal", "sarah", "frank", "Amanda", "Glenn", "jordan" };

            string[] SurNames = { "Smith", "Jones", "Murphy", "moore", "Rorberts", "Rabbit", "stack", "peterson", "johnson" };

            Random rng = new Random();

            for (int i = 0; i < 3; i++)
            {
                int number = rng.Next(0, 3);
                string fName = Firstnames[number];
                number = rng.Next(0, 3);
                string lastname = SurNames[number];
            }
            // Player p1 = new Player("john", "connor");
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedActivity = lbAll.SelectedItem as Player;//item selected
            //null check
            if (selectedActivity != null)
            {
                //move item from left box to right box
                allPlayers.Remove(selectedActivity);
                selectedPlayers.Add(selectedActivity);

                //refresh screen
                lbAll.ItemsSource = null;
                lbAll.ItemsSource = allPlayers;

                lbselected.ItemsSource = null;
                lbselected.ItemsSource = selectedPlayers;
                
                


            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
