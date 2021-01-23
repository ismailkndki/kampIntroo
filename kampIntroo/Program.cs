using System;

namespace kampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // do not repeat yourself - kendini tekrarlama
            // değer tutucu -  alias    
            // double = ondalıklı sayılar için
            // integer(int) = tam sayı
            // if = bir şart durumu vardır şart geçerli ise bu çalışır
            // else = şart geçerli değil ise bu çalışır


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");  
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
