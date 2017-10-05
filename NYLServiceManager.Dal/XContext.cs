using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYLServiceManager.Dal
{
    public class XContext
    {
// variables

// properties        
        public List<ServiceDbModel> Services { get; } = new List<ServiceDbModel>
        {
            new ServiceDbModel{Id = "REZSIORA", Name = "Rezsi óradíj", Unit = "óra", Price = 5000},
            new ServiceDbModel{Id = "KAPCS1", Name = "Kapcsoló", Unit = "db", Price = 7850},
            new ServiceDbModel{Id = "FULLTISZT", Name = "Teljeskörű tisztítás", Unit = "db", Price = 7500},
            new ServiceDbModel{Id = "SZURO1", Name = "szűrőbetét", Unit = "db", Price = 3200}
        };

        public List<PartnerDbModel> Partners { get; } = new List<PartnerDbModel>
        {
            new PartnerDbModel{Id = 1, Name = "Vegyesker Kft.", Zip = "2000", City = "Szentendre", Address = "Alkotmány út 28."},
            new PartnerDbModel{Id = 2, Name = "Jakubek Ödön", Zip = "1156", City = "Budapest", Address = "Erdőkerülő út 77."},
            new PartnerDbModel{Id = 3, Name = "Kupcsulák Tódor", Zip = "4600", City = "Kisvárda", Address = "Petőfi Sándor utca 33."}
        };

        public List<MechanicDbModel> Mechanics { get; } = new List<MechanicDbModel>
        {
            new MechanicDbModel {Id = "Jocó", Name = "Nagy József" },
            new MechanicDbModel {Id = "Pisti", Name = "Kiss istván" },
            new MechanicDbModel {Id = "Sanyi", Name = "Hevesi Sándor" }
        };

        public List<MachineDbModel> Machines { get; } = new List<MachineDbModel>
        {
            new MachineDbModel {SerialNo = "MSG1111458875", Name = "Samsung mosógép" },
            new MachineDbModel {SerialNo = "HTSZ6547711287dssdf8", Name = "Samsung hűtőszekrény" },
            new MachineDbModel {SerialNo = "M000XXX313135", Name = "Elektrolux mosógép" },
            new MachineDbModel {SerialNo = "CF555VVV4518458", Name = "Hajdu centrifuga" },
            new MachineDbModel {SerialNo = "MSG111YYY3313124458", Name = "Ariston mosogatógép" },
            new MachineDbModel {SerialNo = "VS123456874", Name = "Hajdu vasaló" }
        };

        public List<DocHeaderDbModel> DocHeaders { get; } = new List<DocHeaderDbModel>
        {            
        };

        public List<DocItemDbModel> DocItems { get; } = new List<DocItemDbModel>
        {
        };
        

        // constructors


        //events


        // functions




    }
}
