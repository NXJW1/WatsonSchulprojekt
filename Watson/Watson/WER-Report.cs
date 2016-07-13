using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    class WER_Report : Report, HTML
    {
        private string dateiname;
        private DateTime EventTime;
        private int BucketID;
        private string AppName;

        public string addData(string data)
        {
            return data;
        }
        
        public override void reportAusgeben()
        {
            throw new NotImplementedException();
        }

        public void visualisiererReportsHTML()
        {
            throw new NotImplementedException();
        }
    }
}
