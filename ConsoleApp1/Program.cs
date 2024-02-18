using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v = new Vettore(2, 3);
            double l = 3;
            
            Console.WriteLine(v/l);

            Console.ReadLine();
        }
    }
}
