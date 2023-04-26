using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializationDeseri S = new SerializationDeseri();
            S.Serializable();
            S.Deserialization();
            Console.ReadKey();
        }
    }
}
