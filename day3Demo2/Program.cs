using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter which year");
            try
            {
             int leapYear = Int32.Parse(Console.ReadLine());

            Console.WriteLine("you input is {0}",leapYear);

            
            }
            catch (Exception)
            {

                Console.WriteLine("your input is  not number");

                Console.ReadKey();
            }

            
        }
    }
}
