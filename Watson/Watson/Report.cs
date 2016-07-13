using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    abstract class Report
    {
        protected string report_ID;

        public abstract void reportAusgeben();
    }
}
