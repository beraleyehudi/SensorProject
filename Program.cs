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
            //SensorType?[] agents = new SensorType?[15];
            //Console.WriteLine(agents.Length);
            //Console.WriteLine(agents[14] == null);



            Agent agent = new BacikAgent("berale");
            
            Logic.Manage();

        }
    }
}





