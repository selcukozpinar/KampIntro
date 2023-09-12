using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";



            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //array- dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "JAva","Python","C#" };






            for (int i=0;i<kurslar.Length;i++)
            {

                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");
            
            
            
            {
            foreach(string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }

            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
