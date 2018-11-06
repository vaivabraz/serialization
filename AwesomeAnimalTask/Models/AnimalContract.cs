using System.Runtime.Serialization;

namespace AwesomeAnimalTask
{
    [DataContract]
    public class AnimalContract
    {
        [DataMember]
        internal string Name { get; set; }
        [DataMember]
        internal string AnimalType { get; set; }
        [DataMember]
        internal double Weight { get; set; }
    }
}
