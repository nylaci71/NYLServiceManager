using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class PartnerViewModel : BaseModel
    {
// variables

// properties
        public ObservableCollection<Partner> PartnerList { get; set; }
        public Partner SelectedPartner { get; set; }

// constructors
        public PartnerViewModel()
        {
            PartnerList = new ObservableCollection<Partner>();
            var ctx = new Context();
            foreach (var partner_ in ctx.Partners)
            {
                PartnerList.Add(new Partner(partner_));
            }
        }        


// events




// functions





    }
}
