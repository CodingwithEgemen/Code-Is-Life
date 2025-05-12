using System;

class Program
{
    static void Main()
    {
        // Ödev dosyasında verilen örnek prim oranları:
        const double YUKSEK_ORAN = 0.30; // Yüksek performans için %30 prim
        const double ORTA_ORAN = 0.20;   // Orta performans için %20 prim
        const double DUSUK_ORAN = 0.10;  // Düşük performans için %10 prim

        // Toplam prim hesaplamak için değişken başlatılıyor
        double toplamPrim = 0.0; //değişkenine sıfır (0.0) değeri atanıyor. Bu, toplam primin başlangıçta sıfır olduğunu belirtir. Yani, henüz hiçbir çalışan için prim hesaplanmadığı için toplam prim sıfırdır.

        // Program ismi
        Console.WriteLine(" --- Çalışan Performans Prim Hesaplama Aracı --- ");
        Console.WriteLine(" ----------------------------------------------- ");

        // Kullanıcıdan kaç çalışan olduğunu girmesi istenir. 
        Console.Write(" 1- Hesaplamak istediğiniz çalışan sayısı nedir: ");
        int calisanSayisi = int.Parse(Console.ReadLine());

        // Sayaç başlatılır
        int sayac = 1; // int sayac= 1 ifadesi, bir sayaç değişkeni tanımlar ve başlangıç değerini 1 olarak ayarlar. Bu değişken, çalışanları sırasıyla işlemek için kullanılır.

        // While döngüsü ile tüm çalışanların hesaplaması yapılır.
        while (sayac <= calisanSayisi)
        {
            Console.WriteLine(sayac + " Çalışan bilgilerini giriniz: ");

            // Maaş bilgisi alınır.
            Console.Write("Yıllık maaş bilgisi giriniz (TL): ");
            double maas = double.Parse(Console.ReadLine());

            // Performans skoru alınır
            Console.Write("Performans skoru giriniz (1 --> Dusuk, 2 --> Orta, 3 --> Yuksek): ");
            int skor = int.Parse(Console.ReadLine());

            // Prim başlangıçta sıfır olarak tanımlanır.
            double prim = 0.0;

            // Performans skoruna göre prim hesaplama işlemi yapılır.
            if (skor == 3)
            {
                prim = maas * YUKSEK_ORAN;
            }
            else if (skor == 2)
            {
                prim = maas * ORTA_ORAN;
            }
            else if (skor == 1)
            {
                prim = maas * DUSUK_ORAN;
            }

            // Geçerli skor girildiyse prim gösterilir ve toplam prime eklenir, hesaplama yapılır.
            if (skor >= 1 && skor <= 3)
            {
                Console.WriteLine("Çalışanın kazandığı prim: " + prim + " TL");
                toplamPrim += prim;
            }
            else
            {
                // Hatalı skor girildiyse kullanıcı bilgilendirilir ve hesaplama yapılamaz. 
                Console.WriteLine("Geçersiz performans skoru girdiniz. Maalesef prim hesaplanmadı.");
            }

            // Bir sonraki çalışana geçmek için sayaç artırılır.
            sayac++; // sayac++ ifadesinin amacı, bir sonraki çalışana geçmek için sayaç değerini artırmaktır, bu sayede while (sayac <= calisanSayisi)'ndaki tüm çalışanların hesapları yapılır. 
        }

        Console.WriteLine("Toplam ödenecek prim: " + toplamPrim + " TL"); // Tüm çalışanların toplam primi gösterilir ise bu şekilde gösterilir.
    }
}
