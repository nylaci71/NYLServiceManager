using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class Partner : BaseModel
    {
// variables
        int id_; // partner autoincrement egyedi azonosítója 
        string name_; //patner neve 50char
        string zip_; //partner irányítószáma 4char
        string city_; // partner település 40char
        string address_; // partner címe 50char

// properties
        public int Id { get { return id_; } set { id_ = value; OnPropertyChange(); } }
        public string Name { get { return name_; } set { name_ = value; OnPropertyChange(); } }
        public string Zip { get { return zip_; } set { zip_ = value; OnPropertyChange(); } }
        public string City { get { return city_; } set { city_ = value; OnPropertyChange(); } }
        public string Address { get { return address_; } set { address_ = value; OnPropertyChange(); } }

// constructors
        public Partner()
        {
        }

        public Partner(PartnerDbModel dbModel)
        {
            Id = dbModel.Id;
            Name = dbModel.Name;
            Zip = dbModel.Zip;
            City = dbModel.City;
            Address = dbModel.Address;
        }

//events




// functions




    }
}
