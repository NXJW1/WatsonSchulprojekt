using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Watson
{
    class Rechner
    {
        private List<User> users;
        private string os;
        private string name;
        private string MAC;

        public Rechner()
        {
            os = Environment.OSVersion.ToString();
            name = Environment.MachineName;
            
            NetworkInterface[] NetworkAdapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in NetworkAdapters)
            {
                if (adapter.NetworkInterfaceType.ToString() == "Ethernet")
                {
                    MAC = adapter.GetPhysicalAddress().ToString();
                    break;
                }
            }        
        }
    }
}
