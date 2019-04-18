using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 17, 11, 9, 3, 4, 11, 6, 11, 8, 7 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }

        static void printRepeating(int[] arr, int size)
        {
            int i, j;
            Console.WriteLine("Element which occur three times");
            for (i = 0; i < size; i++)
            {
                if (arr[i] == arr[j++])
                    Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
