using System;
using System.Collections.Generic;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rast = new Random();
            List<Ogrenci> ogrencilist = new List<Ogrenci>();
            string[] adList = { "Ali", "Veli", "Hakan", "Serkan", "Hakan", "Serdar" };
            string[] soyadList = { "AKIN", "SEZEN", "EKİN", "TEKİN", "TOK", "SAYGILI" };
            for (int i = 0; i < 10; i++)
            {
                int okulNo = rast.Next(1, 1000);
                string ad = adList[rast.Next(0, 5)];
                string soyad = soyadList[rast.Next(0, 5)];
                int yazili1 = rast.Next(0, 100);
                int yazili2 = rast.Next(0, 100);
                int perf1 = rast.Next(0, 100);
                int perf2 = rast.Next(0, 100);
                Ogrenci yeniOgrenci = new Ogrenci(okulNo, ad, soyad, yazili1, yazili2, perf1, perf2);
                ogrencilist.Add(yeniOgrenci);
            }
            Console.WriteLine($"{"Okul No",8}" +
                              $"{"Ad", 8}" +
                              $"{"Soyad",8}" +
                              $"{"1.Yazili",9}" +
                              $"{"2.Yazili",9}" +
                              $"{"1.Perf",8}" +
                              $"{"2.Perf",8}" +
                              $"{"Ort.",8}" +
                              $"{"Durum",6}");
            foreach (Ogrenci ogr in ogrencilist)
            {

                Console.WriteLine(ogr.ToString());
            }

        }
    }

    class  Ogrenci
    {
        int okulNo;
        string ad;
        string Soyad;
        int yazili1;
        int yazili2;
        int performans1;
        int performans2;

        public Ogrenci(int okulNo, 
                        string ad,  
                        string Soyad, 
                        int yazili1, 
                        int yazili2,
                        int performans1,
                        int performans2)
        {

            this.okulNo = okulNo;
            this.ad = ad;
            this.Soyad = Soyad;
            this.yazili1 = yazili1;
            this.yazili2 = yazili2;
            this.performans1 = performans1;
            this.performans2 = performans2;
        }
        
        public double ortalama()
        {
            return (yazili1 + yazili2 + performans1 + performans2) / 4.0;
        }

        public override string ToString()
        {
            return $"{okulNo,8}{ad,8}" +
                   $"{Soyad,8}{yazili1,9}{yazili2,9}" +
                   $"{performans1,8}{performans2,8}{ortalama(),8}" +
                   $"{(ortalama()<50?"KADLI":"GEÇTİ"),6}";
        }


    }
}
