using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listOne = new List<int>(new int[] { 1, 2, 3, 4 });
            List<int> listTwo = new List<int>(new int[] { 5, 6, 7, 8});
            Console.WriteLine("##### ZIP + ######");
            var finalList = listOne.Zip(listTwo, (x, y) => x + y);
            foreach(int i in finalList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("##### ZIP - ######");
            var finalList2 = listOne.Zip(listTwo, (x, y) => x - y);
            foreach (int i in finalList2)
            {
                Console.WriteLine(i);
            }

            //AGGREGATES
            Console.WriteLine("##### Aggregates + ######");
            List<int> listAgg = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{listAgg.Aggregate((x,y) => x + y)}");

            Console.WriteLine("##### Aggregates - ######");
            List<int> listAgg2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{listAgg2.Aggregate((x, y) => x - y)}");

            Console.WriteLine("##### Aggregates Strings ######");
            List<string> listAgg3 = new List<string>() { "1", "2", "3", "4", "5" };
            Console.WriteLine($"{listAgg3.Aggregate((x, y) => x + " "+y)}");

            //AVERAGES
            Console.WriteLine("AVERAGES");
            List<int> listAvg = new List<int>() { 5, 10, 15, 50, 62 };
            Console.WriteLine(listAvg.Average());

            //ALL & ANY
            Console.WriteLine("ALL//ANY");

            List<int> listAllAny = new List<int>() { 7, 2, 15, 33, 61 };
            Console.WriteLine("All > 10 ? {0}", listAllAny.All(x => x > 3));
            Console.WriteLine("Any > 10 ? {0}", listAllAny.Any(x => x > 3));
            Console.WriteLine("Any value = 62 ? {0}", listAllAny.Any(x => x == 62));
            Console.WriteLine("Any value = 61 ? {0}", listAllAny.Any(x => x == 61));

            //SUPPRIMER LES DOUBLONS
            List<int> listDistinct = new List<int>() { 1, 2, 1, 2, 3, 4, 5, 5, 5 };
            Console.WriteLine("Nombre de valeurs uniques dans la liste : {0}", listDistinct.Distinct().Count());

            //Comparaisons entre listes
            Console.WriteLine("Comparaison de listes");
            List<int> listComp1 = new List<int>(new int[] { 1, 2, 3, 4 });
            List<int> listComp2 = new List<int>(new int[] { 5, 2, 7, 3 });
            Console.WriteLine("Elements de la premiere liste non présents dans la seconde : {0}", string.Join(", ", listComp1.Except(listComp2)));
            Console.WriteLine("Elements de la seconde liste non présents dans la première : {0}", string.Join(", ", listComp2.Except(listComp1)));

            Console.ReadLine();
        }
    }
}
