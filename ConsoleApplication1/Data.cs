using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Data : ICloneable
    {
        protected Object data;
        public Object Value
        {
            get
            {
                return data;
            }
            protected set
            {
                data = value;
            }
        }
        public Data(Object data)
        {
            this.data = data;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
