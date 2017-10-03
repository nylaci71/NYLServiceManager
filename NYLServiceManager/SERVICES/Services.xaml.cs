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
    /// Interaction logic for Services.xaml
    /// </summary>
    public partial class Services : Window
    {
// variables
        readonly ServiceViewModel _vm;

// properties


// constructors
        public Services()
        {
            InitializeComponent();
            _vm = new ServiceViewModel();
            DataContext = _vm;
        }

//events
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {


        }


        
        
        
        
        
// functions




    }
}
