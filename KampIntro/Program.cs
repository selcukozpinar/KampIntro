using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlma
            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faziOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

           if(dolarDun>dolarBugun)
            {

                Console.WriteLine("Azalış butonu");
            }
           else if (dolarDun<dolarBugun)

            {

                Console.WriteLine("artış Butonu");

            }
           else
            {
                Console.WriteLine("DEğişmdi");
            }
                
                
                
                if (sistemeGirisYapmisMi == true)
            {

                Console.WriteLine("Kullanıcı ayarları butonu");


            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            

        }
    }
}
