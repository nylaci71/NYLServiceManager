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
using System.Collections.Generic;

namespace NYLServiceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variables
        readonly MainViewModel _vm;


        // properties
        

        // constructors

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;

        }


// events

        // Partners    
        private void buttonPartners_Click(object sender, RoutedEventArgs e) // get partner
        {
            PartnerViewModel _p_view_model = new PartnerViewModel();
            Partners PartnerForm = new Partners { DataContext = _p_view_model }; ;
            PartnerForm.ShowDialog();
            
            if (PartnerForm.DialogResult == true)
                MessageBox.Show(_p_view_model.SelectedPartner.Name);                
        }


        // Machines
        private void buttonMachines_Click(object sender, RoutedEventArgs e) // get machine
        {
            
        }

        // Mechanics
        private void buttonMechanics_Click(object sender, RoutedEventArgs e) // get mechanic
        {
            
        }


        // Services
        private void buttonNewService_Click(object sender, RoutedEventArgs e) // add new service
        {

        }

        private void buttonEditService_Click(object sender, RoutedEventArgs e) // edit an existing service
        {

        }

        private void buttonDelService_Click(object sender, RoutedEventArgs e) // delete service
        {

        }


        // Items
        private void datagridAddItem_DoubleClick(object sender, MouseButtonEventArgs e) // add article to items
        {

        }

        private void buttonEditItem_Click(object sender, RoutedEventArgs e) // edit an existing item
        {

        }

        private void buttonDelItem_Click(object sender, RoutedEventArgs e) // delete item
        {

        }








        private void buttonAnalytics_Click(object sender, RoutedEventArgs e)
        {
            Partners partners = new Partners();
            partners.Show();
            //partners.DataContext
            //this.Close();
        }

        

        





        // functions




    }
}
