using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekectionSortComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13,45,34,1,23,39,-1,269};
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = arr[i];
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)

                {
                    if (min > arr[j])
                    {
                        min = arr[j]; //reset min valus and min index
                        minIndex = j;
                    }
                }
                arr[minIndex] = arr[i];
                arr[i] = min; // put min value in the first array
                


            }

            Console.WriteLine("the result");
            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");

            }
            Console.ReadLine();
        }
    }
}
