using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insetSortSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,11,6,1};
            // first round 11 ,12 ,34,1
            int insertval = arr[1];
            int insertIndex = 1 - 1;
            while (insertIndex>=0 && insertval<arr[insertIndex])
            {
                arr[insertIndex + 1] = arr[insertIndex];
                insertIndex--;

            }

            arr[insertIndex + 1] = insertval;

            Console.WriteLine("the first round result is ");

            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");
            }
            Console.ReadKey();
            //second round
            int insertval2 = arr[2];
            int insertIndex2 = 2 - 1;
            while(insertIndex2>0 && insertval2<arr[insertIndex2])
            {
                arr[insertIndex2 + 1] = arr[insertIndex2];
                insertIndex2--;
            }
            arr[insertIndex2 + 1] = insertval2;


            foreach (int  num in arr)
            {
                Console.WriteLine("the second round result is");
                Console.Write(num);
                Console.Write("\t");
               
            }
            Console.ReadLine();
        }
    }
}
