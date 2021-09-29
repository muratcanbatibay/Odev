using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri
            {
                MusteriId = 1,
                MusteriTc = "1234654",
                MusteriAdi = "Ali",
                MusteriSoyadi = "Veli"
            };

            Musteri musteri2 = new Musteri
            {
                MusteriId = 2,
                MusteriTc = "123213654",
                MusteriAdi = "Mehmet",
                MusteriSoyadi = "Bak"
            };

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2};
      

            foreach( var musteri in musteriler)
            {
                musteriManager.Add(musteri1);
                Console.WriteLine("-----------------------");
                musteriManager.Add(musteri1);
                Console.WriteLine("-----------------------");               
                musteriManager.Update(musteri1);
                Console.WriteLine("-----------------------");
                musteriManager.Delete(musteri2);
                Console.WriteLine("-----------------------");




            }



        }
    }
}
