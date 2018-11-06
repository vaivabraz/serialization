using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList.Models
{
    //[DataContract]
    public class Animal
    {
        //[DataMember]
        public string Name { get; set; }
        public double Weight { get; set; }
        public string AnimalType { get; set; }
        public int OwnerId { get; set; }
    }
}
