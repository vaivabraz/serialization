using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AwesomeAnimalTask
{

    public class FileReader
    {
        private string filename;

        public FileReader(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("File {0} does not exist.",
                    filename);
            this.filename = filename;
        }

        public List<Animal> ParseStream(List<AnimalContract> streamList)
        {
            List<Animal> pets = new List<Animal>();
            foreach(var pet in streamList)
            {
                if (pet.AnimalType == "Dog")
                {
                    pets.Add(new Dog()
                    {
                        Name = pet.Name,
                        Weight = pet.Weight
                    });
                }
                else if (pet.AnimalType == "Cat")
                {
                    pets.Add(new Cat()
                    {
                        Name = pet.Name,
                        Weight = pet.Weight
                    });
                }
            }
            return pets;
        }

        public List<AnimalContract> ReadStream()
        {
            List<AnimalContract> result = new List<AnimalContract>();
            using (FileStream fs = File.OpenRead(filename))
            {
                fs.Position = 0;
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<AnimalContract>));
                result = (List<AnimalContract>)ser.ReadObject(fs);
                return result;
            }
        }
    }
}
