using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList
{
    class SerializeJson
    {
        public void SerializeAnimalJSON()
        {
            Random r = new Random();
            string path = @"C:\Users\Vaiva\source\repos\NEW\AnimalsList.json";
            using (FileStream fs = File.Create(path))
            {
                for (int i = 1; i < 5; i++)
                {
                    byte[] info = GetOutput(r);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        byte[] GetOutput(Random r)
        {
            AnimalRnd pet;
            string output;
            byte[] info;
            int casernd = r.Next(1, 3);
            switch (casernd)
            {
                case 1:
                    pet = new DogRnd()
                    {
                        Name = "Dog" + r.Next(0, 500).ToString(),
                        Weight = r.Next(5, 50)
                    };
                    break;
                case 2:
                    pet = new CatRnd()
                    {
                        Name = "Cat" + r.Next(0, 500).ToString(),
                        Weight = r.Next(3, 20)
                    };
                    break;
                default:
                    pet = new AnimalRnd()
                    {
                        Name = "Random",
                        Weight = 0
                    };
                    break;
            }
            output = JsonConvert.SerializeObject(pet);
            info = new UTF8Encoding(true).GetBytes(output);
            return info;
        }
    }

    class AnimalRnd
    {
        public string Name { get; set; }
        public double Weight { get; set; }
    }

    class DogRnd : AnimalRnd
    {
        public string AnimalType = "Dog";
    }

    class CatRnd : AnimalRnd
    {
        public string AnimalType = "Cat";
    }
}
