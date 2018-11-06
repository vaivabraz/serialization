using CreateAnimalList.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList
{
    public static class SerializeWithContracts
    {

        public static void SerializeToJsonFile(string path)
        {
            GenerateRandomAnimalRandomInfo generateAnimal = new GenerateRandomAnimalRandomInfo();
            List<Animal> pets = generateAnimal.GenerateRandAnimalList(200);

            using (FileStream fs = File.Create(path))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(List<Animal>));

                ser.WriteObject(fs, pets);
            }
        }
    }

    #region interfaceUnused

    /*
     interface Animal
     {
         [DataMember]
         string Name { get; set; }
         [DataMember]
         double Weight { get; set; }
         string AnimalType { get; set; }
     }
     [DataContract]
     [KnownType(typeof(CreateAnimalList.Dog))]
     class Dog : Animal
     {
         [DataMember]
         public string AnimalType { get; set; } = "Dog";
         public string Name { get; set; }
         public double Weight { get; set; }

     }
     [DataContract]
     [KnownType(typeof(CreateAnimalList.Cat))]
     class Cat : Animal
     {
         public string AnimalType { get; set; } = "Dog";
         public string Name { get; set; }
         public double Weight { get; set; }
     }
     */
    #endregion

}
