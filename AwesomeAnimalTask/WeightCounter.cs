using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAnimalTask
{
    public static class WeightCounter
    {
        public static double AverageWeightAll(List<Animal> animalsList, List<Type> types)
        {
            double weightSum = 0;
            int counter = 0;
            Type objectType;
            foreach(Animal pet in animalsList)
            {
                objectType = pet.GetType();
                var name = objectType.Name;
                if (types.Contains(pet.GetType()))
                {
                    //
                    weightSum += pet.Weight;
                    counter++;
                }
            }

            double averageWeight = weightSum /counter;
            Console.WriteLine("Average weight of ({0}) animals is {1}",
                counter, averageWeight);
            return averageWeight;
        }

    }
}
