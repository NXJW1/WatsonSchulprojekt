using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    class User
    {
        private string name;
        private List<Report> reports;

        public User(string name)
        {
            this.name = name;
        }
    }
}
