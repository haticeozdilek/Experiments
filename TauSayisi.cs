using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0, i = 1;
            int sayi;

            Console.WriteLine("Lütfen bir sayi giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (i != sayi + 1)
            {
                if (sayi % i == 0)
                    sayac++;
                i++;
            }
            if (sayi % sayac == 0)
                Console.WriteLine("Girilen sayi Tau Sayisidir");
            else
                Console.WriteLine("Tau sayisi degildir.");
        }
       
    }

}
