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

namespace NYLServiceManager
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

        private void buttonWorksheet_Click(object sender, RoutedEventArgs e)
        {
            Worksheet worksheet = new Worksheet();
            worksheet.Show();
            //this.Close();
        }

        private void buttonPartners_Click(object sender, RoutedEventArgs e)
        {
            Partners partners = new Partners();
            partners.Show();
            //this.Close();
        }

        private void buttonMachines_Click(object sender, RoutedEventArgs e)
        {
            Machines machines = new Machines();
            machines.Show();
            //this.Close();
        }

        private void buttonServices_Click(object sender, RoutedEventArgs e)
        {
            Services services = new Services();
            services.Show();
            //this.Close();
        }

        private void buttonMechanics_Click(object sender, RoutedEventArgs e)
        {
            Mechanics mechanics = new Mechanics();
            mechanics.Show();
            //this.Close();
        }

        private void buttonAnalytics_Click(object sender, RoutedEventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            //this.Close();
        }

        
    }
}
