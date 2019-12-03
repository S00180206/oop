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
        List<Activity> filteredActivities = new List<Activity>();
        double total = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //list out variables of activity, description, date, cost and type of activity
            Activity a1 = new Activity("Kayaking", "padling in a small boat for two or one person", new DateTime(2019,06,01), 25.35, Activity.ActivityType.water);
            Activity a2 = new Activity("Parachuting", "droping from the sky in paracute", new DateTime(2019,06,01), 70.40, Activity.ActivityType.air);
            Activity a3 = new Activity("Mountain Biking", "off road cycling", new DateTime(2019,06,02), 35.50, Activity.ActivityType.land);
            Activity a4 = new Activity("Hang Gliding", "gliding in the air", new DateTime(2019, 06, 02), 95.99, Activity.ActivityType.air);
            Activity a5 = new Activity("Abseliling", "rock climbing", new DateTime(2019, 06, 03), 45.20, Activity.ActivityType.land);
            Activity a6 = new Activity("Sailing", "sailing a boat", new DateTime(2019, 06, 03), 90.75, Activity.ActivityType.water);
            Activity a7 = new Activity("Helicoptor Tour", "seeing sites in the air", new DateTime(2019,06,03), 99.99, Activity.ActivityType.air);

            allActivities.Add(a1);
            allActivities.Add(a2);
            allActivities.Add(a3);
            allActivities.Add(a4);
            allActivities.Add(a5);
            allActivities.Add(a6);
            allActivities.Add(a7);

            lbAll.ItemsSource = allActivities;




        }
        //add button that when selected activity goes over to the selected list box
        private void BtnSadd_Click(object sender, RoutedEventArgs e)
        {
            //what item is selected
            Activity selectedActivity = lbAll.SelectedItem as Activity;//item selected
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
                total = selectedActivity.Cost + total;
                tbCost.Text = total.ToString();


            }
            else
                ErrorMessage();
        }
        //the reverse of the add button that brings it back the the activity type
        private void BtnARemove_Click(object sender, RoutedEventArgs e)
        {
            //what item is selected
            Activity selectedActivity = lbselected.SelectedItem as Activity;//item selected
            //null check
            if (selectedActivity != null)
            {
                //move item from left box to right box
                allActivities.Add(selectedActivity);
                selectedActivities.Remove(selectedActivity);

                //refresh screen
                RefreshScreen();
                total = total - selectedActivity.Cost;
                tbCost.Text = total.ToString();
            }
            else
                ErrorMessage();
            
                
        }
        //displays messege that nothing was selected
        private void ErrorMessage()
        {
            string errorMessage = "error: nothing was selected";
            tbDescription.Text = errorMessage;
        }

        //refreshing to its sourse
        private void RefreshScreen()
        {
            lbAll.ItemsSource = null;
            lbAll.ItemsSource = allActivities;

            lbselected.ItemsSource = null;
            lbselected.ItemsSource = selectedActivities;
        }

        //dividing the activities to their catagories radio buttons
        private void RbAll_Click(object sender, RoutedEventArgs e)
        {
            filteredActivities.Clear();

            if (rbAll.IsChecked == true)
            {
                //show all
                RefreshScreen();
            }
            else if(rbLand.IsChecked==true)
            {
                //land only
                foreach (Activity activity in allActivities)
                {
                    if (activity.activityType1 == Activity.ActivityType.land)
                        filteredActivities.Add(activity);
                    lbAll.ItemsSource = null;
                    lbAll.ItemsSource = filteredActivities;



                }
            }
            else if (rbWater.IsChecked == true)
            {
                //water only
                foreach (Activity activity in allActivities)
                {
                    if (activity.activityType1 == Activity.ActivityType.water)
                        filteredActivities.Add(activity);
                    lbAll.ItemsSource = null;
                    lbAll.ItemsSource = filteredActivities;



                }
            }
            else if (rbAir.IsChecked == true)
            {
                //air only
                foreach (Activity activity in allActivities)
                {
                    if (activity.activityType1 == Activity.ActivityType.air)
                        filteredActivities.Add(activity);
                    lbAll.ItemsSource = null;
                    lbAll.ItemsSource = filteredActivities;



                }
            }
        }
        //reveals the description of selected activity
        private void LbAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Activity selectedActivity = lbAll.SelectedItem as Activity;//item selected
            //null check
            if (selectedActivity != null)
            {
                tbDescription.Text = selectedActivity.Description;

            }
        }
    }
}
