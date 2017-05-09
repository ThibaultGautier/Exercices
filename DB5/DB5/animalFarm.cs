using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB5
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm()
        {

        }

        //Creation de l'indexer
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count()
        {
            return animalList.Count;
        }

        //Créer un enumerateur qui itere à travers la collection
        IEnumerator IEnumerable.GetEnumerator()
        {
            return animalList.GetEnumerator();
        }

        
          

    }
}
