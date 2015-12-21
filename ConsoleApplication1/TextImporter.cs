using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class TextImporter : Importer
    {
        public TextImporter() : base()
        {

        }

        public String ImportedText
        {
            get
            {
                return (String)this.buffer.Value;
            }
            set { }
        }
    }
}
