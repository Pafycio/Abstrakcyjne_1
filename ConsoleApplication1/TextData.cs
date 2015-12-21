using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class TextData : Data
    {
        public TextData(String text) : base(text)
        {

        }

        public String Text
        {
            get
            {
                return (String)this.data;
            }
            protected set
            {

            }
        }
    }
}
