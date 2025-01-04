using System.Threading.Channels;

namespace Temperature_Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            Display display = new Display();
            AlarmSystem alarmSystem = new AlarmSystem(20);

            temperature.NewTemperatureValue += display.DisplayNewTemperature;
            temperature.NewTemperatureValue += alarmSystem.AlarmNoti;

            while (true)
            {
                Console.WriteLine("Welcome to Temperature Sensor ");
                Console.WriteLine("(1 Set Temprature Value ");
                Console.WriteLine("(2 Set Alarm Temperature Value ");
                Console.WriteLine("(3 Exist");

                var ans = Console.ReadLine();

                switch (ans)
                {
                    case "1":
                        // Set Temerature Value
                        Console.WriteLine("Enter The Temperature Value :");

                        string Temp = Console.ReadLine();

                        int tempValue;

                        while (!int.TryParse(Temp,out  tempValue))
                        {
                            Console.WriteLine("Invalid Input Pls Try Again");
                             Temp = Console.ReadLine();
                        }

                        temperature.SetTemperatureValue(tempValue);

                        break;
                    case "2":
                        // set Sensor Temerature Value
                        Console.WriteLine("Enter The Alarm Value:");

                        string tempstring = Console.ReadLine();

                        int tempInt;

                        while (!int.TryParse(tempstring, out tempInt))
                        {
                            Console.WriteLine("Wrong Input Pls try Againg");
                             tempstring = Console.ReadLine();
                        }

                        alarmSystem.SetAlaramValue(tempInt);

                        break;
                    case "3":
                        return;
                        break;
                    default:
                        Console.WriteLine("Wrong Input Pls Enter The Correct Input");
                        break;
                }



            }
        }
    }
}
