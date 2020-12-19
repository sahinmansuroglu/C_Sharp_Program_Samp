static void Main(string[] args)
        {
            int puan1, puan2, puan3;

            Console.Write("1. Puanı giriniz:");
            puan1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Puanı giriniz:");
            puan2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Puanı giriniz:");
            puan3 = Convert.ToInt32(Console.ReadLine());

            if (puan1 <= 100 & puan1 >= 0 & puan2 <= 100 & puan2 >= 0 & puan3 <= 100 & puan3 >= 0) {
                double ortalama = (puan1 + puan2 + puan3) / 3.0;
                string durum = "Geçti";
                int notKarsiligi;
                if (ortalama >= 85)
                {
                    notKarsiligi = 5;
                }
                else if (ortalama >= 70) {
                    notKarsiligi = 4;
                }
                else if (ortalama >= 60)
                {
                    notKarsiligi = 3;
                }
                else if (ortalama >= 50)
                {
                    notKarsiligi = 2;
                }
                else
                {
                    notKarsiligi = 1;
                    durum = "KAldı..";

                }
                Console.WriteLine($"Ortalamanız:{ortalama}");
                Console.WriteLine($"Durum:{durum}");
                Console.WriteLine($"Not Karşılığı:{notKarsiligi}");
            }
            else
            {

                Console.WriteLine("Girilen Notlarda Hata var (0-100 arasında Olmalı)");
            }

     }
    
