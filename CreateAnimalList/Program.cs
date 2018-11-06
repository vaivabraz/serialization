using System;
using System.IO;
using System.Text;

namespace CreateAnimalList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SerializeJson sj = new SerializeJson();
            sj.SerializeAnimalJSON();*/

            SerializeWithContracts ser = new SerializeWithContracts();
            ser.GenerateList();
        }

    }

}
