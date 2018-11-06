using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList.Models
{
    //[DataContract]
    //[KnownType(typeof(CreateAnimalList.Dog))]
    public class Dog :Animal
    {
        //[DataMember]
        public double DistanceRanPerDay { get; set; }
    }
}
