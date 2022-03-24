using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowyC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("przykladowy tekst");
            int a = 2;

            if(a % 2 == 0)
                Console.WriteLine("Parzysta");
            else
                Console.WriteLine("Niparzysta");
        }
    }
}
