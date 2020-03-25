using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /* 
        Erişim_Belirteci class Classİsmi
        {
           Kodlar
        }
         
         
         */ 

    //public class ToplamBul
    //{
    //    public int a;
    //    public int b;
    //    public int t;

    //    public int Topla(int a, int b)
    //    {
    //        return t = a + b;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            ToplamBul TB = new ToplamBul();

            Console.WriteLine("A Değerini Giriniz:");
            TB.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B Değerini Giriniz:");
            TB.b = Convert.ToInt32(Console.ReadLine());

            ToplamBul TC = new ToplamBul();

            Console.WriteLine(TB.TB(TB.a, TB.b));

            Console.ReadKey();
        }
    }
}
