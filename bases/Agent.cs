using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    public abstract class Agent
    {
        public static int GeneralId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSensors { get; set; }
        public int NumberOfSensorsThathit { get; set; } = 0;
        public Dictionary<SensorType, int> RequiredSensors { get; set; }
        public Dictionary<SensorType, int> AttachedSensors { get; set; } = new Dictionary<SensorType, int>();
        public SensorType?[] AttachedSensorsFromUser { get; set; }
        public List<SensorType> IrrelevantSensors { get; set; }
        public bool Exposed { get; set; } = false;
        public Agent(string name, int numberOfSensors)
        {
            Id = GeneralId++;
            this.Name = name;
            //RequiredSensors = AuxiliaryFunctions.CreateDictOfSensore(numberOfSensors);
            RequiredSensors = new Dictionary<SensorType, int>() { { SensorType.signal, 2 } };
            AttachedSensorsFromUser = new SensorType?[numberOfSensors]; 
            AgentData.agents.Add(this);

        }

        public void AttachSensor(SensorType sensor, int index)
        {
            AttachedSensors.Clear();
            AttachedSensorsFromUser[index] = sensor;
            for (int i = 0; i < AttachedSensorsFromUser.Length; i++)
            {
                SensorType? sensorType = AttachedSensorsFromUser[i];
                if (sensorType != null)
                {
                    if (!AttachedSensors.ContainsKey(sensorType.Value))
                    {
                        AttachedSensors.Add(sensorType.Value, 0);
                    }
                    AttachedSensors[sensorType.Value]++;
                }
            }
            //ExposureScore();
        }
        public void ExposureScore()
        {
            int exposureScore = 0;
            foreach (KeyValuePair<SensorType, int> kvp in RequiredSensors)
            { 
                if (AttachedSensors.ContainsKey(kvp.Key))
                {
                    exposureScore += AttachedSensors[kvp.Key];
                }
            }
            NumberOfSensorsThathit = exposureScore; 
            if (NumberOfSensorsThathit == NumberOfSensors)
            {
                UpdateStatus();
            }
            //ShowExposureScore();
            
        }

        public void ShowExposureScore()
        {
            Console.WriteLine($"the agent {Name} exposed {NumberOfSensorsThathit}/{NumberOfSensors}");
        }

        public void UpdateStatus()
        {
            Exposed = !Exposed;
        }

        public bool IsExposed()
        {
            return Exposed;   
        }

    }
}
