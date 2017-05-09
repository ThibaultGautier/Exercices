using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST ARRAYLIST

            ArrayList array = new ArrayList();

            array.Add(1);
            array.Add("deux");
            array.Add(3);
            array.Add("quatre");

            Console.WriteLine("ArrayList Capacity : {0}", array.Capacity);
            array.Reverse();
            foreach(object o in array)
            {
                Console.WriteLine(o);
            }




            array.Clear();
            

            Console.ReadLine();

        }
    }
}
