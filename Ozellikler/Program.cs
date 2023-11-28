using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ozellikler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 5;
            ucgen.B = 9;
            ucgen.C = -10;
            Console.WriteLine("Ucgenin a={0}",ucgen.A);
            Console.WriteLine("Ucgenin b={0}",ucgen.B);
            Console.WriteLine("Ucgenin c={0}", ucgen.C);
        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("C ye Hatalı bilgi girdiniz lo");
                else
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("B ye hatalı bilgi girdiniz lo");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("C ye Hatalı bilgi girdiniz lo");
                else
                    c = value;
            }
        }
    }
}