using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2_FA_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array to hold grocery list values
            //string[] items = new string[5];

            //declare a new array and assign values in one line of code
            string[] items = new string[] { "cereal","milk","eggs","orange juice","pancake mix"};

            //populate the array with data (values)
            //items[0] = "cereal";
            //items[1] = "milk";
            //items[2] = "eggs";
            //items[3] = "orange juice";
            //items[4] = "pancake mix";

            //print out the grocery list items by pulling from the array
            Console.WriteLine("Items on my grocery list include:\n");
            Console.WriteLine(items[0]);
            Console.WriteLine(items[1]);
            Console.WriteLine(items[2]);
            Console.WriteLine(items[3]);
            Console.WriteLine(items[4]);

            Console.ReadLine();
        }
    }
}
