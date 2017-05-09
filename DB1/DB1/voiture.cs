using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1
{
    class Voiture : IDrivable
    {
        private string Brand{get; set;}
        private int nbrPortiere { get; set; }
        private int nbrRoues { get; set; }

        public Voiture()
        {
            this.Brand = "";
            this.nbrPortiere = 4;
            this.nbrRoues = 4;
        }

        public Voiture(string brand)
        {
            this.Brand = brand;
        }

        public string GetBrand()
        {
            return this.Brand;
        }

        public int GetNombrePortieres()
        {
            return this.nbrPortiere;
        }

        public int GetNombreroues()
        {
            return this.nbrRoues;
        }

        public void Off()
        {
            Console.WriteLine("La voiture est arrêtée");
        }

        public void On()
        {
            Console.WriteLine($"La voiture de la marque {Brand} est allumée");
        }
    }
}
