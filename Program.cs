using System;

namespace OOP2
{
    //SOYUTLAMA(inheritance, miras alma)
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri Gmusteri1 = new GercekMusteri();
            TuzelMusteri Tmusteri1 = new TuzelMusteri();


            Gmusteri1.MusteriNo = "123456";
            Gmusteri1.Adi = "Semra";
            Gmusteri1.Soyadi = "Güneş";

            Tmusteri1.MusteriNo = "142536";
            Tmusteri1.SirketAdi = "Kodlamaio";
            Tmusteri1.VergiNo = "2536985874";


            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            // musteri hem gerçek müşterinin referansını tutabiliyor hemde tüzel müşterinin.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);





        }
    }
}
