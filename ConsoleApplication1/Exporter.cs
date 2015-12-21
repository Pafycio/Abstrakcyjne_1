using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    abstract class Exporter
    {
        public Exporter()
        {

        }

        protected Data buffer;
        public Data ExportData
        {
            get
            {
                return exportData();
            }
            protected set
            {
                
            }
            
        }

        protected virtual Data exportData()
        {
            return null;
        }
    }
}
