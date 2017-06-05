using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Masukkan Jumlah angka sebagai tinggi: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                for (int a=0; a<=i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for (int i=0; i<=n-1; i++)
            {
                for (int a=i; a<n-1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Jumlah n= "+"'" + n + "'" + " sebagai tinggi");
           
        }

    }
}
