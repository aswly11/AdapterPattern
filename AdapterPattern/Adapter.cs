using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        public LegacyLibrary _legacyLibrary { get; set; }
        public Adapter(LegacyLibrary legacyLibrary)
        {
            _legacyLibrary = legacyLibrary;
        }
        public void Request()
        {
            _legacyLibrary.LegacyMethod();
        }
    }
}
