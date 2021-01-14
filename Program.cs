using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Poly_chairman bcb = new Poly_chairman();
            bcb.cricket("Tamim Iqbal", "Shahriar Nafees");
            bcb.cricket("Md. Ashraful", "Mahmudullah Riyad", "Shakib Al Hasan");
            bcb.cricket("Khaled Masud Pilot");
            bcb.cricket("Saif Uddin", "Akbar Ali", "Mashrafe Bin Mortoza", "Nazmul Hossain");
            bcb.cricket("Ahmed Mahir Shoaib", 79);
            Console.ReadLine();

        }
    }
}
