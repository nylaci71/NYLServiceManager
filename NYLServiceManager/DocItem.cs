using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class DocItem : BaseModel
    {
// variables
        int item_id_; // munkalap tételek autoincrement egyedi azonosítója 
        int header_id_; //munkalap fejléc egyedi azonosítója
        int service_id_; // szolgáltattás vagy alapanyag egyedi azonosítója 
        string service_name_; // szolgáltattás vagy alapanyag neve 50char
        string service_unit_; // szolgáltattás vagy alapanyag menyiségi egysége 10char
        int item_price_; // tétel ára
        int item_qty_; // tétel mennyisége

// properties
        public int ItemId { get { return item_id_; } set { item_id_ = value; OnPropertyChange(); } }
        public int HeaderId { get { return header_id_; } set { header_id_ = value; OnPropertyChange(); } }
        public int ServiceId { get { return service_id_; } set { service_id_ = value; OnPropertyChange(); } }
        public string ServiceName { get { return service_name_; } set { service_name_ = value; OnPropertyChange(); } }
        public string ServiceUnit { get { return service_unit_; } set { service_unit_ = value; OnPropertyChange(); } }
        public int ItemPrice { get { return item_price_; } set { item_price_ = value; OnPropertyChange(); } }
        public int ItemQty { get { return item_qty_; } set { item_qty_ = value; OnPropertyChange(); } }

        // constructors
        public DocItem()
        {
        }

        public DocItem(DocItemDbModel dbModel)
        {
            ItemId = dbModel.ItemId;
            HeaderId = dbModel.HeaderId;
            ServiceId = dbModel.ServiceId;
            ServiceName = dbModel.ServiceName;
            ServiceUnit = dbModel.ServiceUnit;
            ItemPrice = dbModel.ItemPrice;
            ItemQty = dbModel.ItemQty;           
        }


//events



// functions

    }
}
