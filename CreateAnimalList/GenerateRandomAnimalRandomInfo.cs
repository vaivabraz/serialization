using CreateAnimalList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList
{
    public class GenerateRandomAnimalRandomInfo
    {
        Random r;

        public GenerateRandomAnimalRandomInfo()
        {
            this.r = new Random();
        }

        public List<Animal> GenerateRandAnimalList(int EntitiesNum)
        {
            List<Animal> pets = new List<Animal>();

            for (int i = 1; i < EntitiesNum; i++)
            {
                Animal pet = GenerateRandomAnimalObject();
                pets.Add(pet);
            }
            return pets;
        }

        public Animal GenerateRandomAnimalObject()
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
}
