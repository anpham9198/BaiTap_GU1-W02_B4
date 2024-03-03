using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9_CauTrucMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float VND;           
            Console.Write("Nhap so tien ban muon doi: ");
            VND = float.Parse(Console.ReadLine());

            float USD = VND/23000;
            Console.Write("So tien doi ra: " + USD);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}


