using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernVpn.MVVM.Model;

namespace ModernVpn.MVVM.ViewModel
{
    internal class ProtectionViewModel
    {
        public ObservableCollection<ServerModel> Servers { get; set; }
        public ProtectionViewModel()
        {
            Servers = new ObservableCollection<ServerModel>();
            for (int i = 0; i < 10; i++)
            {
                Servers.Add(new ServerModel
                {
                    Country = "USA"
                }) ;
            }
        }
    }
}
