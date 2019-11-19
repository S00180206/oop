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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Activity a1 = new Activity("Kayaking", "padling in a small boat for two or one person", new DateTime(01 / 06 / 2019), 25, Activity.ActivityType.water);
            Activity a2 = new Activity("Parachuting", "droping from the sky in paracute", new DateTime(01 / 06 / 2019), 70, Activity.ActivityType.air);
            Activity a3 = new Activity("Mountain Biking", "off road cycling", new DateTime(02 / 06 / 2019), 35, Activity.ActivityType.land);
            Activity a4 = new Activity("Hang Gliding", "gliding in the air", new DateTime(02 / 06 / 2019), 95, Activity.ActivityType.air);
            Activity a5 = new Activity("Abseliling", "rock climbing", new DateTime(03 / 06 / 2019), 45, Activity.ActivityType.land);
            Activity a6 = new Activity("Sailing", "sailing a boat", new DateTime(03 / 06 / 2019), 90, Activity.ActivityType.water);
            Activity a7 = new Activity("Helicoptor Tour", "seeing sites in the air", new DateTime(03 / 06 / 2019), 100, Activity.ActivityType.air);
        }



    }
}
