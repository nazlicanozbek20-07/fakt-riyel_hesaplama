using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktöriyel_hesaplama
{
    internal class Program
    {
        public static int faktoriyel(int sayi)
        {
            int faktoriyel = 1;

            for (int i=1; i<=sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }
        static void Main(string[] args)
        {
            int sayi;

            bool isFirst = true;
            while(true)
            {
                if (isFirst)
                {
                    Console.Write("Bir sayı giriniz: ");
                    isFirst = false;
                }

                sayi = Convert.ToInt32(Console.ReadLine());
                int sonuc = faktoriyel(sayi);
                Console.WriteLine("Sonuç: " + sonuc);
                Console.Write( "Bir sayı giriniz: ");

            }
        }
    }
}
