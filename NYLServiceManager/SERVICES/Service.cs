using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class Service : BaseModel
    {
// variables
        string id_; // szolgáltatás autoincrement egyedi azonosítója 20char
        string name_; // szolgáltatás megnevezése 50char
        string unit_; // szolgáltatás mennyiségi egysége 10char
        double price_; //szolgáltatás ára dec18.6

// properties
        public string Id { get { return id_; } set { id_ = value; OnPropertyChange(); } }
        public string Name { get { return name_; } set { name_ = value; OnPropertyChange(); } }
        public string Unit { get { return unit_; } set { unit_ = value; OnPropertyChange(); } }
        public double Price { get { return price_; } set { price_ = value; OnPropertyChange(); } }

// constructors
        public Service()
        {
        }

        public Service(ServiceDbModel dbModel)
        {
            Id = dbModel.Id;
            Name = dbModel.Name;
            Unit = dbModel.Unit;
            Price = dbModel.Price;            
        }
        


        //events



        // functions






    }
}
