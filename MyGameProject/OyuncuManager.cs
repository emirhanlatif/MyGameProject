using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class OyuncuManager
    {
        public void Add(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu eklendi.");
        }

        public void Delete(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }

}
