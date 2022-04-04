using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionsortSteps
{
    class Program
    {
        static void Main(string[] args)
        {  
            int[] arr = { 56,43,34,1};
            // First round 1  43 34 26 
            int min = arr[0];
            int minIndex = 0;
            for (int j=0+1;j<arr.Length;j++)
                
            {
                if (min > arr[j])
                {
                    min = arr[j]; //reset min valus and min index
                    minIndex = j;
                }
            }
            arr[minIndex] = arr[0]; 
            arr[0] = min; // put min value in the first array
            Console.WriteLine("First round result");
            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");

            }
            Console.ReadLine();
            //// second round 1 26 43 34 
            int min2 = arr[1];
            int minIndex2 = 0 + 1;
            for (int j = 1+1; j < arr.Length; j++)
            {
                if (min2 > arr[j])
                {
                    min2 = arr[j]; //reset min valus and min index
                    minIndex2 = j;
                }

             }
            arr[minIndex2] = arr[1];
            arr[1] = min2;
            Console.WriteLine("second round result is ");
            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");
                
            }
            Console.ReadLine();
        }
    }
}
