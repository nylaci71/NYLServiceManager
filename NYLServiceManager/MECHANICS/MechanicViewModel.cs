using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class MechanicViewModel
    {
// variables

// properties
        public ObservableCollection<Mechanic> MechanicList { get; set; }
        public Mechanic SelectedMechanic { get; set; }

// constructors
        public MechanicViewModel()
        {
            MechanicList = new ObservableCollection<Mechanic>();
            var ctx = new Context();
            foreach (var mechanic_ in ctx.Mechanics)
            {
                MechanicList.Add(new Mechanic(mechanic_));
            }
        }


// events




// functions

    }
}
