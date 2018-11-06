using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList
{
    class SerializeBinary
    {
        public void SerializeAnimalBin()
        {
            Animal obj = new Animal();
            obj.Name = "Puffy";
            obj.Weight = 3;
  
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(
                @"C:\Users\Vaiva\source\repos\NEW\AnimalsList.bin",
                FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public void DeserializeAnimalBin()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Vaiva\source\repos\NEW\AnimalsList.bin",
                FileMode.Open, FileAccess.Read);
            Animal objnew =
                (Animal)formatter.Deserialize(stream);
            Console.WriteLine(objnew.Name);
        }

        private class Animal
        {
            public string Name { get; set; }
            public int Weight { get; set; }
        }
    }

    

}


