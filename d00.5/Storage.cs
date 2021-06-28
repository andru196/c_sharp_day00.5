using System.Collections.Generic;
using System.Linq;

namespace d00_5
{
    public class Storage
    {

        public bool IsEmpty {get => Elements == 0;}
        public uint Elements;

        
        public Storage(uint size)
        {
            Elements = size;
        }
    }
}