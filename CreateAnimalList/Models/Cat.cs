using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnimalList.Models
{
    //[DataContract]
    //[KnownType(typeof(CreateAnimalList.Cat))]
    public class Cat : Animal
    {
        //[DataMember]
        public int MiceCaughtPerDay { get; set; }
    }
}
