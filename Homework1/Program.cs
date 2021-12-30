using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeleri oluşturma
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();
            //Objelerin özelliklerini verme
            urun1.UrunAdi = "iPhone 11";
            urun1.UrunTur = "Elektronik";
            urun1.UrunID = 1;

            urun2.UrunAdi = "Led Ampul";
            urun2.UrunTur = "Ev Ürünleri";
            urun2.UrunID = 2;

            urun3.UrunAdi = "Sehpa";
            urun3.UrunTur = "Mobilya";
            urun3.UrunID = 3;
            //Objeleri dizi haline getirme
            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            //foreach ile yazdırma
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunID + "." + urun.UrunAdi + " : " + urun.UrunTur);
            }

            //for döngüsü ile yazdırma
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunID + "." + urunler[i].UrunAdi + " : " + urunler[i].UrunTur);
            }

            //while döngüsü ile yazdırma
            int sayac = 0;
            while(sayac < urunler.Length)
            {
                Console.WriteLine(urunler[sayac].UrunID + "." + urunler[sayac].UrunAdi + " : " + urunler[sayac].UrunTur);
                sayac++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunTur { get; set; }
        public int UrunID { get; set; }
    }
}
