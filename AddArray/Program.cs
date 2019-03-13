using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            for (int x = 0; x < nombres.Length; x++)
            {
                nombres[x] = (Console.ReadLine());
            }
            for (int x = 0; x < nombres.Length; x++)
            {
                Console.WriteLine(nombres[x]);
            }
            Console.ReadKey();
        }
    }
}
