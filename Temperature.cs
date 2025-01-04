using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Temperature
    {
        public event EventHandler<TempArgs> NewTemperatureValue;
        private int CurrentTemperature { get; set; }

        public void SetTemperatureValue(int NewValue)
        {
            CurrentTemperature = NewValue;

            NewTemperatureValue.Invoke(this, new TempArgs(NewValue));
        }
    }
}
