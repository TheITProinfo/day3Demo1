using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ArrayBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {   /**
             *   example exchange 2 numbers
             */
            //int n1 = 20;
            //int n2 = 30;
            //int temp = 0;
            //temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("n1 is {0}, n2 is {1}",n1,n2);
            //Console.ReadKey();
            int[] arr = { 4, 3, 5, 2, 1, 0 };

            int n = arr.Length;
            int temp = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }

            }

            foreach (int number in arr)  
            {
                Console.Write(number);
                Console.Write("\t");
            }

            Console.ReadKey();
            
        }
    }
}
