using AwesomeAnimalTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAnimalTask
{
    public static class ReportMaker
    {
        public static void GenerateReport(AnimalWeights reportdata)
        {
            string filename = @"C:\Users\Vaiva\source\repos\NEW\AnimalsReport.json";
            using (FileStream fs = File.Create(filename))
            {
                fs.Position = 0;
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(AnimalWeights));
                ser.WriteObject(fs, reportdata);
            }
        }
    }
}
