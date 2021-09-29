using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        { // ilk olarak sayfanın altında bulunan ürünleri yönetebilmemiz ve 
          // id,name,ve price gibi nitelikleri ekleyebilmemiz için bir ProductManager classı oluşturuyoruz.
          //get ve set ettikten sonra..


            //.. Mainimize gelip ProductManager classında işlem yapabilmemiz için çağırıp,
            //her bir ekleyeceğimiz ürün için heapte adres oluşturma*
            //işlemi ( newleme işlemini*) yapıyoruz.
            ProductManager product1 = new ProductManager();
            ProductManager product2 = new ProductManager();
            ProductManager product3 = new ProductManager();




            //Adresleme işlemleri bittikten sonra aşağıda
            //herbir product nesnelerimizi set ediyoruz ( tanımlıyoruz)
            product1.ProductId = 1;
            product1.ProductName = "Laptop";
            product1.UnitPrice = 1500;

            product2.ProductId = 2;
            product2.ProductName = "Mouse";
            product2.UnitPrice = 10;

            product3.ProductId = 3;
            product3.ProductName = "Keyboard";
            product3.UnitPrice = 15;

            //Ürünleri Listeleyebilmemiz için öncelikle
            //ProductManager içerisinde products isimli bir array oluşturuyoruz.
            //(Bu isimlendirme products yerine başka bir isim de olabilir)
            ProductManager[] products = new ProductManager[] { product1, product2, product3 };




            Console.WriteLine("----FOR DÖNGÜ BAŞLANGICI-----");
            for (int i = 0; i < products.Length; i++)
            {
                //for döngüsünde i ismindeki değişkenimiz products isimli arrayımızın uzunluğunu
                //yani eleman sayısı kadar birer birer artacak ve uzunluğuna ( eleman sayısına eşit olduğunda)
                // artmayı bırakacaktır.






                Console.WriteLine("Ürün ID=" + products[i].ProductId + " " + "Ürün Adı=" + products[i].ProductName + " " + " Ürün Fiyatı" + "=" + products[i].UnitPrice);

                //products arrayını i.elemanına kadar yazdırma işlemi yapıyoruz.
                //Arrayımızın son elelmanına geldiğinde o son elemanı da yazdırıyor ve döngü bitmiş oluyor.
                // Burada products arrayındaki tüm nesnelerin ID'leri,
                // isimleri ve fiyatlarının yazdırması yapılmış oldu.


            }
            Console.WriteLine("--------FOR Döngüsü Bitti-------");


            Console.WriteLine("-----WHILE döngü başlangıcı-----");
            int x = 0;
            while (x < products.Length)
            {
                //Başta değişkeni 0'a eşitliyoruz ve while dögüsüne sokuyoruz.
                //x products arrayının uzunluğuna eşit oluncaya kadar çalışıyor.

                Console.WriteLine("Ürün ID=" + products[x].ProductId + " " + "Ürün Adı=" + products[x].ProductName + " " + " Ürün Fiyatı" + "=" + products[x].UnitPrice);
                // products arrayıdaki her eleman yazdırıldıktan sonra..
                x++;
                //x 1 arttırılıyor.
            }

            Console.WriteLine("-----WHILE DÖNGÜ BİTİŞİ-----");

            Console.WriteLine("------FOREACH DÖNGÜ BAŞLANGICI-------");

            foreach (var product in products)
            {
                //foreach döngü içerisinde products arrayında işlem yapabilmek için
                //product isimli bir değişken tanımlıyoruz.
                // bu değişken foreach ile products arrayını gezebilmemiz için 
                //takma ad görevi görüyor.
                //Tüm arrayda gezintiyi products içindeki ilk product değişkeni 
                // ilk elemana takma ad olarak yapışıyor yazdırıyor sonra diğer elemana geçiyor
                //onu yazdırıyor.
                //Tüm arraydaki elemlar gezildikten sonra döngü bitiyor.

                Console.WriteLine("Ürün ID=" + product.ProductId + " " + "Ürün Adı=" + product.ProductName + " " + " Ürün Fiyatı" + "=" + product.UnitPrice);



            }

            Console.WriteLine("-------FOREACH DÖNGÜ BİTİŞİ------");
        }

        public class ProductManager
        {
            //Herbir ürünün ID, Ürün Adı, Ürün Fiyatına get, set işlemi tanımlıyoruz.
            //Bu sayede Main içerisinde ya da başka sınıflarda, o sınıfın içerisinde
            //Nesneye ait özellik tanımlayabiliyor oluyoruz.

            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
        }


    }
}
