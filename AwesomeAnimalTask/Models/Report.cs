using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAnimalTask.Models
{
    [DataContract]
    public class Report
    {
        [DataMember]
        List<AnimalTypes> Weights { get; set; }
    }

    [DataContract]
    public class AnimalTypes
    {
        public KeyValuePair<string, double> weight {get;set;}
    }

    [DataContract]
    public class AnimalWeights
    {
    [DataMember]
    internal double AllWeights { get; set; }
    [DataMember]
    internal double CatsWeights { get; set; }
    [DataMember]
    internal double DogsWeights { get; set; }
    }
}
