using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10,20,30,40,50,60,70,80,90};
            foreach (int number in arr)
            {
                Console.Write(number);
                Console.Write("\t");
            }
            Console.ReadKey();
        }
    }
}
