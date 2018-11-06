using System;
using System.IO;
using System.Text;

namespace CreateAnimalList
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Vaiva\source\repos\NEW\AnimalsList.json";

            SerializeWithContracts.SerializeToJsonFile(path);

 
        }
    }
}
