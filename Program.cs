using System;

namespace Static_Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi) ;
            Calisan calisan = new Calisan("Merve", "Özderin", "IT") ;
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi) ;
            Calisan calisan1 = new Calisan("Ceylan", "Özderin", "Tasarım") ;
            Calisan calisan2 = new Calisan("Ayşenur", "Demircan", "Üretim") ;
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi) ;

            Console.WriteLine("Sayıların Toplamı: {0}", Islemler.Topla(100,150)) ;
            Console.WriteLine("Sayıların Farkı: {0}", Islemler.Cıkar(800,500)) ;
        }
    }

    class Calisan
    {
        private static int calisanSayisi ;

        public static int CalisanSayisi { get => calisanSayisi ; set => calisanSayisi = value ;}

        private string Isim ;
        private string Soyisim ;
        private string Departman ;

        static Calisan()
        {
            calisanSayisi = 0 ;
        }

        public Calisan ( string isim, string soyisim, string departman)
        {
            this.Isim = isim ;
            this.Soyisim = soyisim ;
            this.Departman = departman ;
            calisanSayisi ++ ;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2 ;
        }

        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2 ;
        }
    }
}
