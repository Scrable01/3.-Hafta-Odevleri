using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hafta_Odevleri
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int a = 2; int b = 3; int с = 6; int d = 1;

            Console.WriteLine(" (a<b)&&(c<d) -->" + ((a < b) && (с < d)));
            Console.WriteLine(" (a<b)ll(c<d) -->" + ((a < b) || (с < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine(" (a<b)&(c<d) --> " + ((a < b) & (с < d)));
            Console.WriteLine(" (a<b)/(c<d) - -> " + ((a < b) | (с < d)));
            Console.WriteLine(" (a<b)^(c<d) -->" + ((a < b) ^ (с < d)));
            Console.ReadLine();

        }
    }
}
