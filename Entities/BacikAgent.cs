using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensorProject
{
    internal class BacikAgent : Agent
    {
        public BacikAgent(string name) : base(name, 2)
        {
            NumberOfSensors = 2;
            Name = name;
        }
        


    }
}
