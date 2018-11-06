using AwesomeAnimalTask.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AwesomeAnimalTask
{
    partial class Program
    {
        public static void Main()
        {
            string filename = @"C:\Users\Vaiva\source\repos\NEW\AnimalsList.json";
            FileReader fr = new FileReader(filename);
            List<AnimalContract> streamList = fr.ReadStream();
            List<Animal> animalList = fr.ParseStream(streamList);

            List<Type> typeAll = new List<Type>() { typeof(Dog), typeof(Cat) };
            List<Type> typeCat = new List<Type>() { typeof(Cat) };
            List<Type> typeDog = new List<Type>() { typeof(Dog) };
            double weightAll = WeightCounter.AverageWeightAll(animalList, typeAll);
            double weightCats = WeightCounter.AverageWeightAll(animalList, typeCat);
            double weightDogs = WeightCounter.AverageWeightAll(animalList, typeDog);

            AnimalWeights report = new AnimalWeights() { };
            report.AllWeights = weightAll;
            report.CatsWeights = weightCats;
            report.DogsWeights = weightDogs;

            List <List<Type>> alllist = new List<List<Type>>()
            {
                new List<Type>() { typeof(Dog), typeof(Cat) },
                new List<Type>() { typeof(Cat) },
                new List<Type>() { typeof(Dog) }
            };

            /*foreach (List<Type> types in List<List<Type>> alllist)
            {}
            */

            ReportMaker.GenerateReport(report);


            Console.ReadLine();
        }
    }
}
