using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hafta_Odevleri8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n;

            Console.Write("Bir Sayi Girin: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Artim Miktarı: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i < n;)

            {
                Console.Write("{0} ", i);
                i += a;

            }
            Console.ReadLine();
        }
    }
}
