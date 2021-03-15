using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Mutlu";
            musteri1.TelNo = "55541111";
            musteri1.HesapTuru = "Vadesiz";
            musteri1.Id = 553;
            
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "Varlı";
            musteri2.TelNo = "55141221";
            musteri2.HesapTuru = "Vadeli";
            musteri2.Id = 554;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Tahsin";
            musteri3.Soyad = "Zorlu";
            musteri3.TelNo = "55841411";
            musteri3.HesapTuru = "Vadesiz";
            musteri3.Id = 555;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("------Musteri Ekleme-------");
            musteriManager.Ekle(musteri1);

            Console.WriteLine("-------------Müsteri Silme-------");
            musteriManager.Silme(musteri2);

            Console.WriteLine("--------Listeleme---------------");
            musteriManager.Listeleme(musteriler);





        }
    }
}
