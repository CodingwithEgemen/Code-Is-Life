using System; // C#'ın en temel kütüphanesidir.

class Program // C#'da kodlar bir sınıf yani class içerisine yazılır.
{
    static void Main() // C#'da kodlar üzerinde çalışılmaya buradan başlanır ve bilgisayar önce burayı okur.
    {
        Random rnd = new Random(); // Rastgele sayı üretir ayrıca bu bir sınıftır.
        int gizliSayi = rnd.Next(10); // Sistem 0 ile 10 arasında rastgele bir sayı tutar.
        int hak = 3; // Kullanıcının rastgele sayıyı doğru tahmin edebilmesi için 3 adet hakkı vardır.

        Console.WriteLine("0 ile 10 arasında bir sayı tuttum.");
        Console.WriteLine("Toplam 3 hakkın var, şansına güveniyorsan oyuna başla!");

        for (int i = 1; i <= hak; i++) // For döngüsü içerisindeki i değişken değeri 3 adet tahmin ürettirir, çünkü "hak" değişkenimiz 3'dür.

        {
            Console.Write("Tahmin " + i + ": "); // Üst satırdaki kodumuz sayesinde Tahmin 1, Tahmin 2 ve Tahmin 3 ekranımıza yazdırılır.
            string giris = Console.ReadLine();
            int tahmin = Convert.ToInt32(giris); // Kullanıcının girdiği değer string olarak alınır, Convert ise girilen değeri tam sayıya çevirir.

            if (tahmin == gizliSayi)
            {
                Console.WriteLine("Tebrikler, Sayıyı doğru tahmin ettin!");
                return; // Doğru tahmin yapılırsa "Tebrikler, Sayıyı doğru tahmin ettin!" mesajı yazar ve return ile programı bitirir.
            }
            else
            {
                Console.WriteLine("Hatalı tahmin, tekrar dene."); //Eğer tahmin doğru değilse "Hatalı tahmin, tekrar dene." satırı çalışır ve kullanıcıya “Hatalı tahmin” denir.
            }
        }

        Console.WriteLine("Maalesef tüm haklarını kullandın, 3 hakkın olduğunu unutma! Doğru sayı: " + gizliSayi); // 3 tahmin hakkı biterse ve doğru tahmin yapılamamışsa bu satır çalışır. Kullanıcıya oyunu kaybettiğini söyler ve doğru sayıyı ekrana yazdırır. 
    }
}