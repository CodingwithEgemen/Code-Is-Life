using System;

class Program
{
    static void Main()
    {
        // Sabit KDV oranını tanımlıyorum (%18), ödevde örnek verilen %18'idi.
        const double KDV_ORANI = 0.18;

        // Kullanıcıya kaç ürün ekleyeceğini soruyoruz.
        Console.WriteLine("Kaç farklı ürün eklemek istiyorsunuz?");
        int urunSayisi = int.Parse(Console.ReadLine()); // Girilen sayıyı tam sayıya çeviriyoruz.

        double araToplam = 0; // Tüm ürünlerin toplam tutarını burada saklayacağız, başlangıç değerini 0 olarak atıyoruz.

        Console.WriteLine("\n-----------------------------\n");

        // Ürün sayısı kadar dönen döngü başlatıyoruz.
        for (int i = 1; i <= urunSayisi; i++)
        {
            // Her ürün için sırayla başlık yazdırıyorum çünkü çok fazla sayı olduğundan programımızın karmaşık gözükmemesi gerek.
            Console.WriteLine(i + ". ÜRÜN BİLGİLERİ");
            Console.WriteLine("------------------");

            Console.Write("Ürün adı: ");
            string urunAdi = Console.ReadLine(); // Ürünün adını kullanıcıdan alıyoruz.

            Console.Write("Birim fiyatı (TL): ");
            double birimFiyat = double.Parse(Console.ReadLine()); // Fiyatı ondalık sayıya çeviriyoruz.

            Console.Write("Kaç adet aldınız: ");
            int adet = int.Parse(Console.ReadLine()); // Adet sayısını tam sayıya çeviriyoruz.

            // Ürünün toplam fiyatını hesaplıyoruz.
            double urunToplam = birimFiyat * adet;

            // Hesaplanan ürüne ait olan Toplamı yazdırıyoruz.
            Console.WriteLine("→ " + adet + " adet " + urunAdi + " için toplam: " + urunToplam + " TL\n");

            // Bu toplamı genel ara toplama ekliyoruz.
            araToplam = araToplam + urunToplam;
        }

        // Özet kısmı:
        Console.WriteLine("-----------------------------");
        Console.WriteLine("         SİPARİŞ ÖZETİ       ");
        Console.WriteLine("-----------------------------");

        // Ara toplamı gösteriyoruz:
        Console.WriteLine("Ara Toplam : " + araToplam + " TL");

        // KDV'yi hesaplayıp gösteriyoruz:
        double kdv = araToplam * KDV_ORANI;
        Console.WriteLine("KDV (%18)  : " + kdv + " TL");

        // Genel toplamı hesaplayıp gösteriyoruz:
        double genelToplam = araToplam + kdv;
        Console.WriteLine("Genel Toplam: " + genelToplam + " TL");

        Console.WriteLine("-----------------------------");
    }
}
