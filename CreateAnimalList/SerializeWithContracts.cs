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
    class SerializeWithContracts
    {

        public void GenerateList()
        {
            string path = @"C:\Users\Vaiva\source\repos\NEW\AnimalsList.json";
            Random r = new Random();

            using (FileStream fs = File.Create(path))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(List<Animal>));
                List<Animal> pets = GetFullOutput();
                ser.WriteObject(fs, pets);
                /*for (int i = 1; i < 5; i++)
                {
                    Animal info = GetOutput(r);

                    ser.WriteObject(fs, info);
                }*/
            }
        }

        public List<Animal> GetFullOutput()
        {
            List<Animal> pets = new List<Animal>();
            Random r = new Random();
            for (int i = 1; i < 200; i++)
            {
                Animal pet = GetOutput(r);
                pets.Add(pet);
            }
            return pets;
        }

        Animal GetOutput(Random r)
        {
            Animal pet;
            int casernd = r.Next(1, 3);
            switch (casernd)
            {
                case 1:
                    pet = new Animal()
                    {
                        Name = "Dog" + r.Next(0, 500).ToString(),
                        Weight = r.Next(5, 50),
                        AnimalType = "Dog"
                    };
                    break;
                case 2:
                    pet = new Animal()
                    {
                        Name = "Cat" + r.Next(0, 500).ToString(),
                        Weight = r.Next(3, 20),
                        AnimalType = "Cat"
                    };
                    break;
                default:
                    pet = new Cat()
                    {
                        Name = "Random",
                        Weight = 0,
                        AnimalType = ""
                    };
                    
                    break;
            }
            return pet;
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

    [DataContract]
    class Animal
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public string AnimalType { get; set; }
    }

    [DataContract]
    [KnownType(typeof(CreateAnimalList.Dog))]
    class Dog : Animal
    {
        [DataMember]
        public string AnimalType = "Dog";
    }

    [DataContract]
    [KnownType(typeof(CreateAnimalList.Cat))]
    class Cat : Animal
    {
        [DataMember]
        public string AnimalType = "Cat";
    }

}
