using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class TempArgs
    {
        public int TempValue { get; set; }
        public TempArgs (int value)
        {
            TempValue = value;
        }
    }
}
