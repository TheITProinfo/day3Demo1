using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertSortComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15,12,16,1,100,-50};

            for (int i = 1; i < arr.Length; i++)
            {
                int insertval = arr[i];
                int insertIndex = i - 1;
                while (insertIndex >= 0 && insertval < arr[insertIndex])
                {
                    arr[insertIndex + 1] = arr[insertIndex];
                    insertIndex--;

                }

                arr[insertIndex + 1] = insertval;

                
            }

            Console.WriteLine("the  result is ");

            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");
            }
            Console.ReadKey();

        }
    }
}
