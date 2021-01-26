using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class OyunManager
    {
        public void Add(Oyun oyun)
        {
            Oyun[] oyunlar = new Oyun[] {oyun};
            foreach (var item in oyunlar)
            {
                Console.WriteLine(oyun.Name);
            }
        }

        public void Delete(Oyun oyun)
        {
            Console.WriteLine("Oyun silindi.");
        }
        
    }
}
