using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class KampanyaManager
    {
        public void Add(Kampanya kampanya)
        {
            Kampanya[] kampanyalar = new Kampanya[] {kampanya};
            foreach (var item in kampanyalar)
            {
                Console.WriteLine(kampanya.Name);
            }
        }
        public void Delete(Kampanya kampanya)
        {
            
        }
        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
