using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class ServiceViewModel
    {
// variables

// properties
        public ObservableCollection<Service> ServiceList { get; set; }
        public Service SelectedService { get; set; }

// constructors
        public ServiceViewModel()
        {
            ServiceList = new ObservableCollection<Service>();
            var ctx = new Context();
            foreach (var service_ in ctx.Services)
            {
                ServiceList.Add(new Service(service_));
            }
        }


// events




// functions




    }
}
