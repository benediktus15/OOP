using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search___Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraySearch = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 8;
            //var index = 0;

            Console.WriteLine(BinarySearch(arraySearch, target));
            
        }

        static int BinarySearch(int[] input, int find)
        {
            int first = 0;
            int last = input.Length - 1;
            int middle = (first + last) / 2;

            if (input[middle] == find)
                return middle;

            return -1;
        }
    }
}
