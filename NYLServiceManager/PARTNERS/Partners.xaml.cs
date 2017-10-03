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
        readonly PartnerViewModel _vm;

// properties
            

// constructors
        public Partners()
        {
            InitializeComponent();
            _vm = new PartnerViewModel();            
            DataContext = _vm;
        }

//events
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            

        }

     
        





// functions






    }
}
