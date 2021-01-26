using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu() { NationalId = "123456789", Name = "Emirhan", LastName = "Latif", YearOfBirth = 2000 };
            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Add(oyuncu1);

            Kampanya kampanya1 = new Kampanya() { Id = 1, Name = "Yılbaşı Kampanyası", IndirimTutari = 20 };
            Kampanya kampanya2 = new Kampanya() { Id = 2, Name = "Yaz Kampanyası", IndirimTutari = 10 };
            Kampanya kampanya3 = new Kampanya() { Id = 3, Name = "Bahar Kampanyası", IndirimTutari = 40 };
            Kampanya[] kampanyalar = new Kampanya[] { kampanya1, kampanya2, kampanya3 };
            KampanyaManager kampanyaManager = new KampanyaManager();
            Console.WriteLine("Kampanyalarımız:");         
            kampanyaManager.Add(kampanya1);
            kampanyaManager.Add(kampanya2);
            kampanyaManager.Add(kampanya3);
            Console.WriteLine("-----------");

            Oyun oyun1 = new Oyun() { Id = 11, Name = "Fifa21",OyunFiyati=80 };
            Oyun oyun2 = new Oyun() { Id = 12, Name = "GTA5", OyunFiyati = 50 };
            Oyun oyun3 = new Oyun() { Id = 13, Name = "NBA 2K20", OyunFiyati = 60 };
            OyunManager oyunManager = new OyunManager();
            Console.WriteLine("Oyunlarımız:");
            oyunManager.Add(oyun1);
            oyunManager.Add(oyun2);
            oyunManager.Add(oyun3);

            OyunSatis oyunSatis = new OyunSatis();
            oyunSatis.Satis(oyuncu1, oyun1, kampanyalar);

            Console.ReadLine();  
        }
}
}
