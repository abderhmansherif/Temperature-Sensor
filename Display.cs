using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Display
    {
        public void DisplayNewTemperature(object o , TempArgs tempArgs)
        {
            Console.WriteLine($"The New Temperature Degree is: {tempArgs.TempValue} From Dispaly");
        }
    }
}
