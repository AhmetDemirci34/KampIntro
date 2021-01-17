using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0; // değişkenlerin başlangıç değeri 0 olarak ayarlanıyor. 
            while (sayi % 2 == 0)  // koşulda sayi değişkeninin çift olup olmadığına bakılıyor.  
            {
                toplam = toplam + sayi; //döngü içerisinde sayi değişkeninin değeri toplama ekleniyor.  
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());  // Girilen değer sayi değişkenine atanıyor.  
            }
            Console.WriteLine("Girilen Çift Sayıların Toplamı = " + toplam); // Toplam sonuç yazdırılıyor.

            Console.ReadKey();

        }
    }
}
