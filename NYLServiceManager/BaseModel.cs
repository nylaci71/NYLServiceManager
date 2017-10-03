using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NYLServiceManager
{    
    public class BaseModel : INotifyPropertyChanged
    {
// variables
// properties
// constructors
        
// events
        public event PropertyChangedEventHandler PropertyChanged;
        
// functions
        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
