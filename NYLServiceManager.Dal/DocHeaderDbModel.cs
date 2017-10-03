using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYLServiceManager.Dal
{
    public class DocHeaderDbModel
    {
// variables


// properties
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

// constructors



//events



// functions
    }
}
