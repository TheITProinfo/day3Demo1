using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4MethodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = Program.GetMaxnumber(100a,101);
            int num = GetMaxnumber(100, 101);
            Console.WriteLine("the maximum number is {0}",num);
            Console.ReadLine();
        }
    
    /// <summary>
    /// this method get maximum number from 2 prameter
    /// 
    /// </summary>
    /// <param name="n1">integer number</param>
    /// <param name="n2">integer number</param>
    /// <returns></returns>
     static int GetMaxnumber(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    
    }
}
