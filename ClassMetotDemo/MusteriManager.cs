using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi : " + musteri.Ad + musteri.Soyad);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri çıkarıldı : "+ musteri.Ad + musteri.Soyad);
        }

        public void Listeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müsterilerimiz");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + musteri.Soyad);
            }
        }
    }
}
