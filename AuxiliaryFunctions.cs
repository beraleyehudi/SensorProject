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
       
        public static Dictionary<SensorType, int> CreateDictOfSensore(int range)
        {
            int RandomRange = Sensor.Sensortypes.Length - 1;
            Random random = new Random();
            Dictionary<SensorType, int> sensors = new Dictionary<SensorType, int>();
            for (int i = 0; i < range; i++)
            {
                int index = random.Next(RandomRange);
                if (!sensors.ContainsKey(Sensor.Sensortypes[index]))
                {
                    sensors.Add(Sensor.Sensortypes[index], 0);
                }
                sensors[Sensor.Sensortypes[index]]++;

            }
            return sensors;
        }

        public static string Input(string inputMessage)
        {
            Console.WriteLine();
            Console.WriteLine(inputMessage + ":\n ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public static int Input(string inputMessage, int range)
        {
            string input;
            int intInput = 0;
            Console.WriteLine();
            do
            {
                Console.WriteLine(inputMessage + ":\n ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out intInput) || intInput < 1 || intInput > range);
            Console.WriteLine();
            return intInput;
        }

        public static string PrintMenu(string title, string[] options)
        {
            int choice = 0;
            Console.WriteLine("\n" + title + ":" +
                "\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}:  {options[i]}");
            }
            string input = Input("Enter your choice");

            while (!int.TryParse(input, out choice) || choice > options.Length || choice < 1)
            {
                Console.WriteLine("was not prece correct choice");
                input = Input("Enter your choice");
            }

            return options[choice - 1];
        }


        public static SensorType PrintMenu(string title, SensorType[] options)
        {
            int choice = 0;
            Console.WriteLine("\n" + title + ":" +
                "\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}:  {options[i]}");
            }
            string input = Input("Enter your choice");

            while (!int.TryParse(input, out choice) || choice > options.Length || choice < 1)
            {
                Console.WriteLine("was not prece correct choice");
                input = Input("Enter your choice");
            }

            return options[choice - 1];
        }

        public static void PrintDictionary(Dictionary<SensorType, int> dict)
        {
            foreach (KeyValuePair<SensorType, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }


    }
}



