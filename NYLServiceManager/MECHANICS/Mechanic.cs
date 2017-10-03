using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class Mechanic : BaseModel
    {
// variables
        string id_; // szerelő rövid egyedi neve 20char
        string name_; // szerelő teljes neve 50char

// properties
        public string Id { get { return id_; } set { id_ = value; OnPropertyChange(); } }
        public string Name { get { return name_; } set { name_ = value; OnPropertyChange(); } }

// constructors
        public Mechanic()
        {
        }

        public Mechanic(MechanicDbModel dbModel)
        {
            Id = dbModel.Id;
            Name = dbModel.Name;
        }

// events



// functions



    }
}
