using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Importer
    {
        public Importer()
        {

        }

        protected Data buffer;
        public void ImportData(Data dataToSendToImporter)
        {
            this.buffer = dataToSendToImporter;
        }

    }
}
