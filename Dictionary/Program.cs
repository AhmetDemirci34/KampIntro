using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            string isim;

            if (Ogrenci.TryGetValue(No, out isim))
            {
                Console.WriteLine(isim);
            }
            else
            {
                Console.WriteLine("sdsdsdsds");
            }

            //if (Ogrenci.TryGetValue(No, out isim))
            //    Console.WriteLine(isim);
            //else
            //    Console.WriteLine("Öğrenci Bulunamadı.");


            Console.ReadKey();
        }
    }
}
