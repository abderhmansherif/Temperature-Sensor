using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is sensor Alarm when The Temperature is Greater than AlarmValue System 
 * And Alarm Value By Dafault is 20 
 */
namespace Temperature_Sensor
{
    internal class AlarmSystem
    {
        private int AlarmValue { get; set; }

        public AlarmSystem(int TempAlarm)
        {
            AlarmValue = TempAlarm;
        }

        public void SetAlaramValue(int value)
        {
            AlarmValue = value;
            Console.WriteLine("Set Seccussfully");
        }

        public void AlarmNoti(object o, TempArgs tempArgs)
        {
            if(tempArgs.TempValue > AlarmValue)
                Console.WriteLine("Hey From \"Alarm NotiFication System \" Warning !! The Temoerature Degree is Greater Than The Alarm Value");
        }
    }
}
