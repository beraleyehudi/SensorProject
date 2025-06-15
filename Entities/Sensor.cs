using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    internal class BacikSensor : Sensor
    {
         
        
        public BacikSensor() : base()
        {
            Type = SensorType.basic;
          
        }
        protected override void Active()
        {
            Console.WriteLine("basic sensor is active");
        }

    }
}
