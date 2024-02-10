using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Table of 2.");

            int number = 2;
            

            for (int i = 1; i <= 10; i++)
            {
                int result;

                result = number * i;

                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }

            Console.ReadKey();
        }
    }
}
