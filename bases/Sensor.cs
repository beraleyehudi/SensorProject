using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    abstract class Sensor
    {
        public static SensorType[] Sensortypes = new SensorType[] { SensorType.basic, SensorType.audio, SensorType.thermal, SensorType.pulse, SensorType.motion, SensorType.magnetic, SensorType.signal, SensorType.light };
        public int GeneralId = 0; 

        public SensorType Type;
        public int Id { get; set; } = 0;
        public Sensor()
        {
           Id = GeneralId++;
        }
        protected abstract void Active();

    }

}
   



    

        
           
        

