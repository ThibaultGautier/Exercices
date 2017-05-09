using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Peugeot");
            voiture1.On();
            Console.WriteLine("La voiture a {0} portières et {1} roues", voiture1.GetNombrePortieres(), voiture1.GetNombreroues());
            voiture1.Off();
            Console.ReadLine();
        }
    }
}
