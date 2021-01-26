using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class OyunSatis:SameProperties
    {
        public void Satis(Oyuncu oyuncu,Oyun oyun,Kampanya[] kampanyalar)
        {
            Console.WriteLine("Alıcı Bilgileri:");
            Console.WriteLine("TC No: "+oyuncu.NationalId);
            Console.WriteLine("Ad Soyad: "+ oyuncu.Name+" "+oyuncu.LastName);
            if (oyun.Id == 12)
            {
                Console.WriteLine("Oyun: "+oyun.Name+"  Fiyatı: "+oyun.OyunFiyati);
                Console.WriteLine("İndirimli Fiyat: "+(oyun.OyunFiyati-kampanyalar[1].IndirimTutari)+"("+kampanyalar[1].Name+")");
            }
            if (oyun.Id == 11)
            {
                Console.WriteLine("Oyun: " + oyun.Name + "  Fiyatı: " + oyun.OyunFiyati);
                Console.WriteLine("İndirimli Fiyat: " + (oyun.OyunFiyati - kampanyalar[0].IndirimTutari) + "(" + kampanyalar[0].Name + ")");
            }
            if (oyun.Id == 13)
            {
                Console.WriteLine("Oyun: " + oyun.Name + "  Fiyatı: " + oyun.OyunFiyati);
                Console.WriteLine("İndirimli Fiyat: " + (oyun.OyunFiyati - kampanyalar[2].IndirimTutari) + "(" + kampanyalar[2].Name + ")");
            }



        }
    }
}
