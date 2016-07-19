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
        private List<User> users = new List<User>();
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


            //Variablen
            String[] sysroot = Environment.SystemDirectory.Split(':');
            String Pfad = sysroot[0] + ":\\";
            List<String> found = new List<String>();

            //Alle Benutzer herausfinden
            foreach(String Benutzer in System.IO.Directory.GetDirectories(Pfad + "Users"))
            {
                found.Add(Benutzer);
            }

            //Ungewünschte wieder entfernen
            found.Remove(Pfad + "Users\\All Users");
            found.Remove(Pfad + "Users\\Default");
            found.Remove(Pfad + "Users\\Default User");
            found.Remove(Pfad + "Users\\Public");
            found.Remove(Pfad + "Users\\ADMINI~1");
            found.Remove(Pfad + "Users\\Default.migrated");
            
            foreach (String Benutzer in found)
            {
                string Nutzername = Benutzer.Replace(Pfad + "Users\\","");
                User Nutzer = new User(Nutzername);
                users.Add(Nutzer);
            }
        }
    }
}
