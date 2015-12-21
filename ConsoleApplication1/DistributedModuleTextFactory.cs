using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class DistributedModuleTextFactory : DistributedModuleFactory
    {
        public DistributedModuleTextFactory(String text) : base(text)
        {

        }

        public override Data CreateData()
        {
            return new TextData(this.data as String);
        }

        public override Exporter CreateExporter()
        {
            return new TextExporter(this.data as String);
        }

        public override Importer CreateImporter()
        {
            TextImporter im = new TextImporter();
            im.ImportData(new TextData(this.data as String));
            return im;
        }
    }
}
