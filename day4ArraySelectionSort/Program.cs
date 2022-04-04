using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ArraySelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 140, 2200, 33, 20, 51, -1,44 };
            int n = arr.Length;
            

            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                //int temp = arr[min];
                //arr[min] = arr[i];
                //arr[i] = temp;
                // Program.Swap(arr,i,min);
                Swap(arr, i, min);
            }

            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write("\t");
            }
            Console.ReadLine();
        }
/// <summary>
/// exchange arr[min] with arr[0]
/// </summary>
/// <param name="arr"></param> 
/// <param name="i"></param> index for NO. i 
/// <param name="j"></param> minimum
        static void Swap(int[]arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    
    }
}
