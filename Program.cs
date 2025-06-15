using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;


namespace sensorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent = new BacikAgent("berale");
            Console.WriteLine(agent.Id);
            Console.WriteLine(agent.RequiredSensors.Length);
            
            foreach (SensorType sensor in agent.RequiredSensors)
            {
                Console.WriteLine(sensor);
            }
           
            
        }
    }
}
