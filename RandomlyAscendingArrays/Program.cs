using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomlyAscendingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int[7];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                
                int number = rnd.Next(100);
                myArray[i] = number;
                Console.WriteLine(myArray[i]);
                string message = "Position # " + i + " contains " + myArray[i];
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
