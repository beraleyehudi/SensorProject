using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    public static class Logic
    {
        public static void Manage()
        {
            Prints.Welcome();
            foreach (Agent agent in AgentData.agents)
            {

                while (!agent.IsExposed())
                {
                    SensorType sensor = Prints.AttachingSensor();
                    int index = Prints.SelectIndex(agent.NumberOfSensors);
                    agent.AttachSensor(sensor, index);
                    agent.ExposureScore();
                    agent.ShowExposureScore();
                }
                Prints.Success();
            }
        }
    }
}
