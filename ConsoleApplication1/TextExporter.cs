using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class TextExporter : Exporter
    {
        
        public TextExporter(String text) : base()
        {
            this.buffer = new TextData(text);
        }

        protected override Data exportData()
        {
            if (this.buffer != null)
            {
                Data tmp = (Data)this.buffer.Clone();
                this.buffer = null;
                return tmp;
            }
            else
            {
                return new TextData("");
            }
        }
    }
}
