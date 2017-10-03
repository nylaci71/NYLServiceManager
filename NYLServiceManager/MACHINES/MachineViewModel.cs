using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class MachineViewModel : BaseModel
    {
// variables

// properties
        public ObservableCollection<Machine> MachineList { get; set; }
        public Machine SelectedMachine { get; set; }

// constructors
        public MachineViewModel()
        {
            MachineList = new ObservableCollection<Machine>();
            var ctx = new Context();
            foreach (var machine_ in ctx.Machines)
            {
                MachineList.Add(new Machine(machine_));
            }
        }


// events




// functions




    }
}

