using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYLServiceManager.Dal;

namespace NYLServiceManager
{
    class MainViewModel : BaseModel
    {
        // variables

        // properties
        public ObservableCollection<DocItem> DocItemList { get; set; }
        public DocHeader Header { get; set; }


        // constructors
        public MainViewModel()
        {
            DocItemList = new ObservableCollection<DocItem>();
            var ctx = new Context();
            foreach (var _doc_item in ctx.DocItems)
            {
                DocItemList.Add(new DocItem(_doc_item));
            }
        }

// events


// functions






    }
}
