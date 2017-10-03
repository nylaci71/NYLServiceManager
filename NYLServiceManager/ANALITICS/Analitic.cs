using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYLServiceManager
{
    class Analitic : BaseModel
    {

// variables
        

// properties        
        // Header data
        public int Id { get; set; }
        public string DocNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerZip { get; set; }
        public string PartnerCity { get; set; }
        public string PartnerAddress { get; set; }

        public string MachineSerialNo { get; set; }
        public string MachineName { get; set; }

        public string MechanicId { get; set; }
        public string MechanicName { get; set; }

        // item data
        public int ItemId { get; set; }
        //        public int HeaderId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceUnit { get; set; }
        public int ItemPrice { get; set; }
        public int ItemQty { get; set; }

// constructors



//events



// functions



        

    }
}
