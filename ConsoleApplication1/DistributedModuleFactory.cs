using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    abstract class DistributedModuleFactory
    {
        protected object data;
        public DistributedModuleFactory(Object data)
        {
            this.data = data;
        }

        public abstract Data CreateData();

        public abstract Exporter CreateExporter();

        public abstract Importer CreateImporter();
    }
}
