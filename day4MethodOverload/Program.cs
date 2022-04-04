using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 100;
            int z = 300;
            double y2 = 3.31;

            Console.WriteLine(" result:X+y+Z is {0}",Add(x,y,z));
            Console.WriteLine("result x+Y2 is {0}",Add(x,y2));
            Console.WriteLine("result x+y is {0}",Add(x,y));
            Console.ReadLine();
        }


        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(int x, double y)
        {
            return x + y;
        }

        static int Add(int x , int y, int z)
        {
            return x + y + z;
        }
    }
}
