using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
   public class MusteriManager
    {
        public void Add(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi!");
            Console.WriteLine("Müşteri Id = " + musteri.MusteriId + " " + "Müşteri Adı= " + musteri.MusteriAdi);


        }

        public void Update(Musteri musteri)
        {

            Console.WriteLine("Müşteri Güncellendi!");
            Console.WriteLine("Müşteri Id = " + musteri.MusteriId + " " + "Müşteri Adı= " + musteri.MusteriAdi);
        }

        public void Delete(Musteri musteri)
        {

            Console.WriteLine("Müşteri Silindi!");
            Console.WriteLine("Müşteri Id = " + musteri.MusteriId + " " + "Müşteri Adı= " + musteri.MusteriAdi);

        }


    }
}
