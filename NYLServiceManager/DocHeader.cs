using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class DocHeader : BaseModel
    {
        // variables
        int id_; // munkalap fejlécek autoincrement egyedi azonosítója 
        string doc_no_; //munkalap száma 20char
        DateTime creation_date_; //munkalap kelte 10char
        DateTime delivery_date_; // munkalap teljesítésének kelte 10char
        string _; // partner címe 50char

        int partner_id_; // munkalap partner autoincrement egyedi azonosítója 
        string partner_name_; //munkalap patner neve 50char
        string partner_zip_; //munkalap partner irányítószáma 4char
        string partner_city_; // munkalap partner település 40char
        string partner_address_; // munkalap partner címe 50char

        string machine_serial_no_; // munkalap gép (egyedi) gyáriszáma 30char
        string machine_name_; // munkalap gép megnevezése 50char

        string mechanic_id_; // munkalap szerelő rövid egyedi neve 20char
        string mechanic_name_; // munkalap szerelő teljes neve 50char


        // properties
        public int Id { get { return id_; } set { id_ = value; OnPropertyChange(); } }
        public string DocNo { get { return doc_no_; } set { doc_no_ = value; OnPropertyChange(); } }
        public DateTime CreationDate { get { return creation_date_; } set { creation_date_ = value; OnPropertyChange(); } }
        public DateTime DeliveryDate { get { return delivery_date_; } set { delivery_date_ = value; OnPropertyChange(); } }

        public int PartnerId { get { return partner_id_; } set { partner_id_ = value; OnPropertyChange(); } }
        public string PartnerName { get { return partner_name_; } set { partner_name_ = value; OnPropertyChange(); } }
        public string PartnerZip { get { return partner_zip_; } set { partner_zip_ = value; OnPropertyChange(); } }
        public string PartnerCity { get { return partner_city_; } set { partner_city_ = value; OnPropertyChange(); } }
        public string PartnerAddress { get { return partner_address_; } set { partner_address_ = value; OnPropertyChange(); } }

        public string MachineSerialNo { get { return machine_serial_no_; } set { machine_serial_no_ = value; OnPropertyChange(); } }
        public string MachineName { get { return machine_name_; } set { machine_name_ = value; OnPropertyChange(); } }

        public string MechanicId { get { return mechanic_id_; } set { mechanic_id_ = value; OnPropertyChange(); } }
        public string MechanicName { get { return mechanic_name_; } set { mechanic_name_ = value; OnPropertyChange(); } }


        // constructors
        public DocHeader()
        {
        }

        public DocHeader(DocHeaderDbModel dbModel)
        {
            Id = dbModel.Id;
            DocNo = dbModel.DocNo;
            CreationDate = dbModel.CreationDate;
            DeliveryDate = dbModel.DeliveryDate;
            PartnerId = dbModel.PartnerId;
            PartnerName = dbModel.PartnerName;
            PartnerZip = dbModel.PartnerZip;
            PartnerCity = dbModel.PartnerCity;
            PartnerAddress = dbModel.PartnerAddress;
            MachineSerialNo = dbModel.MachineSerialNo;
            MachineName = dbModel.MachineName;
            MechanicId = dbModel.MechanicId;
            MechanicName = dbModel.MechanicName;
        }
        
//events




// functions




    }
}
