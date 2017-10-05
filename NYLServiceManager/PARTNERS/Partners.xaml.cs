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
using System.Windows.Shapes;

namespace NYLServiceManager
{
    /// <summary>
    /// Interaction logic for Partners.xaml
    /// </summary>
    public partial class Partners : Window
    {
// variables
        

// properties
            

// constructors
        public Partners()
        {
            InitializeComponent();            
        }

//events         

        private void grd_Partners_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Insert)
            {
                SelectPartner();
            }
            else if (e.Key == Key.Enter)
            {
                MessageBox.Show("Cikk módosítása");
                e.Handled = true;                
            }
            else if (e.Key == Key.Add)
            {
                MessageBox.Show("Új cikk");
                e.Handled = true;
            }
            else if (e.Key == Key.Subtract)
            {
                MessageBox.Show("Cikk törlése");
                e.Handled = true;
            }
        }

        private void btn_PartnerSelect_Click(object sender, RoutedEventArgs e)
        {
            SelectPartner();
        }


// functions

        private void SelectPartner()
        {            
            var _ctx = (PartnerViewModel)DataContext;
            
            _ctx.SelectedPartner = grd_Partners.SelectedItem as Partner;
            DialogResult = _ctx.SelectedPartner != null;
            Close();            
        }




    }
}
