using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensorProject.Enums;

namespace sensorProject
{
    public static class Prints
    {
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Exposure game");
        }

        public static void Name(string name)
        {
            Console.WriteLine($"The name of this agent is {name}");
        }

        public static SensorType AttachingSensor()
        {
            return AuxiliaryFunctions.PrintMenu("Each sensor will you want to attaching", Sensor.Sensortypes);
        }

        public static int SelectIndex(int range)
        {
            return AuxiliaryFunctions.Input($"Select index between 1 and {range}", range) - 1;
        }

        public static void Success()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You made it");
            Console.ResetColor();
        }
    }
}
