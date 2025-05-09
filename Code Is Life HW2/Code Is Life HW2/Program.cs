using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan birinci sayı alınır:
        Console.Write("Lütfen birinci sayıyı giriniz: "); // Ekrana "Lütfen birinci sayıyı giriniz: " yazdırılır.
        string input1 = Console.ReadLine(); // input1 metin olarak alınır.
        double sayi1 = double.Parse(input1); // Değer double'a dönüştürülür.

        // Kullanıcıdan ikinci sayı alınır:
        Console.Write("Lütfen ikinci sayıyı giriniz: "); // Ekrana "Lütfen ikinci sayıyı giriniz: " yazdırılır.
        string input2 = Console.ReadLine(); // input1 metin olarak alınır.
        double sayi2 = double.Parse(input2); // Değer double'a dönüştürülür.

        // Toplama işlemi yapılır:
        double toplam = sayi1 + sayi2;

        // Ortalama işlemi yapılır:
        // Sayılarımız double türünde olduğu için küsüratlı değerler de hesaplanabilir.
        double ortalama = toplam / 2;

        Console.WriteLine("Girilen sayıların toplamı: " + toplam); // Toplam değeri ekrana yazdırılır.
        Console.WriteLine("Girilen sayıların ortalaması: " + ortalama); // Ortalama değeri ekrana yazdırılır.

        Console.WriteLine("Lütfen programdan çıkmak için herhangi bir tuşa basınız.");
        Console.ReadKey();
    }
}
