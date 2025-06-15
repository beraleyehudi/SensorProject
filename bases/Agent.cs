using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    abstract class Agent
    {
        public static int GeneralId = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public int NumberOfSensors { get; set; }
        public int NumberOfSensorsThathit { get; set; }
        public SensorType[] RequiredSensors { get; set; }
        public Sensor[] AttachedSensors { get; set; }
        public List<Sensor> IrrelevantSensors { get; set; }
        public bool Exposed { get; set; } = false;
        public Agent(string name, int numberOfSensors)
        {
            Id = GeneralId++;
            this.Name = name;
            RequiredSensors = AuxiliaryFunctions.CreateListOfSensore(numberOfSensors);
        }
        
    }
}
