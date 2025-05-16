//using System.Runtime.ConstrainedExecution;

//Ödev Açıklaması:
//Aşağıdaki C# kod bloğu, kullanıcıdan iki sayı alıp bu sayıların toplamını hesaplar. Ancak, kodda bazı hatalar bulunmaktadır.
//while (true)
//{
//    try
//    {
//        Console.Write("İlk Sayıyı Gir : ");
//string input1 = Console.ReadLine();
//var number1 = Convert.ToInt32(input1);

//if (number1 <= 0)
//    throw new ArgumentOutOfRangeException(innerException: null, message: "İlk sayı için girdiğiniz değer 0'dan büyük olmalıdır!");

//Console.Write("İkinci Sayıyı Gir : ");
//string input2 = Console.ReadLine();
//var number2 = Convert.ToInt32(input2);

//if (number2 <= 0)
//    throw new ArgumentOutOfRangeException(message: "İkinci sayı için girdiğiniz değer 0'dan büyük olmalıdır!", null);

//var total = number1 + number2;

//Console.WriteLine($"Verdiğiniz {input1} sayısı ile {input2} sayısının toplamı : {total}");

//throw new Exception();
//    }
//    catch (ArgumentOutOfRangeException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Hatalı bir değer girdiniz!");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Bilinmeyen bir hata oluştur.");
//    }
//}


//Görevler:
//Kodu İnceleyin: Verilen kodun ne yaptığını ve hangi durumlarda hata oluşabileceğini anlamaya çalışın. Kodun akışını ve hata yönetimi mekanizmasını inceleyin.
//Hataları Giderin: Kodda, ikinci sayıyla ilgili bir hata oluştuğunda programın başa dönüp ilk sayıyı tekrar sorması gerekirken, bu gerçekleşmemektedir. Bu hatayı giderin. Yani, hem ilk sayı hem de ikinci sayı girişinde hata oluşursa, programın kullanıcıya tekrar sayıları sormasını sağlayın.
//Ek Hata Kontrolleri Ekleyin: Kullanıcının sayı yerine metin girmesi durumunda FormatException hatası oluşur. Bu hatayı daha spesifik bir mesajla kullanıcıya bildirin.
//Döngüyü Sonlandırın: Şu anda while(true) döngüsü sonsuz bir döngüdür. Kullanıcı doğru giriş yaptığında (yani herhangi bir hata oluşmadığında) döngüyü sonlandıracak bir mekanizma ekleyin. throw new Exception(); satırını kaldırın ve döngüyü sonlandırmak için break; kullanın.
//Kodun Çalışmasını Test Edin: Farklı senaryoları deneyerek kodun doğru çalıştığından emin olun. Örneğin:
//Geçerli sayılar girin (örneğin, 5 ve 10).
//Geçersiz sayılar girin (örneğin, -5 veya 0).
//Sayı yerine metin girin (örneğin, "abc").
//Geliştirilmiş Kodu Açıklayın: Yaptığınız değişiklikleri ve bu değişikliklerin kodu nasıl etkilediğini açıklayan bir yorum ekleyin. Özellikle, eklediğiniz hata kontrollerini ve döngüyü sonlandırma mekanizmasını detaylı bir şekilde açıklayın.
//İpuçları:
//try-catch bloklarını kullanarak hataları yakalayın ve uygun şekilde işleyin.
//if ifadelerini kullanarak giriş verilerini kontrol edin ve gerekirse hata fırlatın.
//break komutunu kullanarak döngüden çıkın.
//Kodunuzu yazarken ve test ederken dikkatli olun ve her adımda ne yaptığınızı anlamaya çalışın.
//Ek Notlar:
//Bu ödev, C# programlama dilinde hata yönetimi (exception handling) kavramını anlamanızı ve uygulamanızı amaçlamaktadır.
//Kodunuzun okunabilir ve anlaşılır olmasına özen gösterin.
//Sorunuz olursa veya yardıma ihtiyacınız olursa çekinmeden sorun.
//Başarılar!



using System;

class Program
{
    static void Main()
    {
        // Sonsuz döngü başlatıyoruz. Hatalı giriş olursa tekrar sormasını bekliyoruz.
        while (true)
        {
            try
            {
                // Kullanıcıdan ilk sayıyı alıyoruz.
                Console.Write("İlk sayıyı girin: ");
                string input1 = Console.ReadLine(); // Program kullanıcının yazdığı yazıyı okuyor.
                int number1 = Convert.ToInt32(input1); // Yazıyı tam sayıya çeviriyor.

                // Eğer sayı 0 veya daha küçükse hata mesajı gösteriyor.
                if (number1 <= 0)
                {
                    Console.WriteLine("İlk sayı 0'dan büyük olmalı!");
                    continue; // Baştan başlıyor ve tekrar sayıyı soruyor.
                }

                // Kullanıcıdan ikinci sayıyı alıyoruz.
                Console.Write("İkinci sayıyı girin: ");
                string input2 = Console.ReadLine(); // Kullanıcının yazdığı ikinci sayıyı okuyor.
                int number2 = Convert.ToInt32(input2); // Yazıyı tam sayıya çeviriyor.

                // Eğer ikinci sayı da 0 veya daha küçükse hata mesajı gösteriyor.
                if (number2 <= 0)
                {
                    Console.WriteLine("İkinci sayı 0'dan büyük olmalı!");
                    continue; // Baştan başlıyor ve tekrar sayıyı soruyor.
                }

                // İki sayının toplamını buluyoruz.
                int toplam = number1 + number2;

                // Sonucu ekrana yazdırıyoruz.
                Console.WriteLine("Verdiğiniz " + number1 + " ve " + number2 + " sayılarının toplamı: " + toplam);

                // Her şey doğruysa döngü bitiyor.
                break;
            }
            catch (FormatException)
            {
                // Eğer kullanıcı sayı yerine harf veya yazı yazarsa bu kısım çalışıyor ve ekrana "Lütfen sadece sayı girin!" yazdırılıyor.
                Console.WriteLine("Lütfen sadece sayı girin!");
            }
        }
    }
}
