using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    public static class AuxiliaryFunctions
    {
        public static SensorType[] CreateListOfSensore(int range)
        {
            int RandomRange = Sensor.Sensortypes.Length - 1;
            Random random = new Random();
            List<SensorType> sensores = new List<SensorType>();
            for (int i = 0; i < range; i++)
            {
                sensores.Add(Sensor.Sensortypes[random.Next(RandomRange)]);
            }
            return sensores.ToArray();
        }


    }
}
