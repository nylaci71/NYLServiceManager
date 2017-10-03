using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class Machine : BaseModel
    {
// variables        
        string serial_no_; // gép (egyedi) gyáriszáma 30char
        string name_; // gép megnevezése 50char

// properties        
        public string SerialNo { get { return serial_no_; } set { serial_no_ = value; OnPropertyChange(); } }
        public string Name { get { return name_; } set { name_ = value; OnPropertyChange(); } }

// constructors
        public Machine()
        {
        }

        public Machine(MachineDbModel dbModel)
        {            
            SerialNo = dbModel.SerialNo;
            Name = dbModel.Name;
        }

//events
                


// functions






    }
}
