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

namespace CA2_S00180206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> allActivities = new List<Activity>();
        List<Activity> selectedActivities = new List<Activity>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Activity a1 = new Activity("Kayaking", "padling in a small boat for two or one person", new DateTime(2019,06,01), 25, Activity.ActivityType.water);
            Activity a2 = new Activity("Parachuting", "droping from the sky in paracute", new DateTime(2019,06,01), 70, Activity.ActivityType.air);
            Activity a3 = new Activity("Mountain Biking", "off road cycling", new DateTime(2019,06,02), 35, Activity.ActivityType.land);
            Activity a4 = new Activity("Hang Gliding", "gliding in the air", new DateTime(2019, 06, 02), 95, Activity.ActivityType.air);
            Activity a5 = new Activity("Abseliling", "rock climbing", new DateTime(2019, 06, 03), 45, Activity.ActivityType.land);
            Activity a6 = new Activity("Sailing", "sailing a boat", new DateTime(2019, 06, 03), 90, Activity.ActivityType.water);
            Activity a7 = new Activity("Helicoptor Tour", "seeing sites in the air", new DateTime(2019,06,03), 100, Activity.ActivityType.air);

            allActivities.Add(a1);
            allActivities.Add(a2);
            allActivities.Add(a3);
            allActivities.Add(a4);
            allActivities.Add(a5);
            allActivities.Add(a6);
            allActivities.Add(a7);

            lbAll.ItemsSource = allActivities;




        }

        private void BtnSadd_Click(object sender, RoutedEventArgs e)
        {
            //what item is selected
            Activity selectedActivity = lbAll.SelectedItems as Activity;//item selected
            //null check
            if (selectedActivity != null)
            {
                //move item from left box to right box
                allActivities.Remove(selectedActivity);
                selectedActivities.Add(selectedActivity);

                //refresh screen
                lbAll.ItemsSource = null;
                lbAll.ItemsSource = allActivities;

                lbselected.ItemsSource = null;
                lbselected.ItemsSource = selectedActivities;

            }

        }

        private void BtnARemove_Click(object sender, RoutedEventArgs e)
        {
            //what item is selected
            Activity selectedActivity = lbselected.SelectedItems as Activity;//item selected
            //null check
            if (selectedActivity != null)
            {
                //move item from left box to right box
                allActivities.Add(selectedActivity);
                selectedActivities.Remove(selectedActivity);

                //refresh screen
                lbAll.ItemsSource = null;
                lbAll.ItemsSource = allActivities;

                lbselected.ItemsSource = null;
                lbselected.ItemsSource = selectedActivities;

            }
        }
    }
}
