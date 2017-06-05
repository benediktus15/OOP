using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace C_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 12;
            int z;

            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n - x; y++)
                {
                    z = n - x - y;
                    Console.WriteLine("{" + x + "," + y + "," + z + "}");
                }
            }
        }
    }
}