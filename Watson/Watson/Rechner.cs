using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

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
            //TODO: MAC-Adresse hinzufügen            
        }
    }
}
