using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] day = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
            for (int i = 0; i < day.Length; i++)
            {
                Console.WriteLine("No.{0} month has {1}days",i+1,day[i]);
            }
            Console.ReadLine();
        }

    }
}
