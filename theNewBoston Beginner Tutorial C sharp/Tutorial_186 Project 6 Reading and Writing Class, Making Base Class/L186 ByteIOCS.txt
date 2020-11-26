using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteOrderIO
{
    // L186 rename class
    //class ByteIO
    public abstract class BaseIO
    {
        // L186 holds the big and little endian read and write
        public enum byteorder
        {
            BigEndian,
            LittleEndian
        }
        // L186 protected variable to store big or little endian data, depending which one we use
        // used in this class or its derived class
        protected byteorder Byteorder;
    }
}
