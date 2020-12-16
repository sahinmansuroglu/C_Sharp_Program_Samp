 //Girilen Bir rakamı yazıya çeviren program (Dizi Kullanılarak)
static void Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen Bir Rakam Giriniz:");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girilen Sayi={girilenSayi}");

                string[] rakamYazi = { "Sıfır", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };

                Console.WriteLine($"{girilenSayi}->{rakamYazi[girilenSayi]}");
            }
            catch (Exception)
            {

                Console.WriteLine("Hata Oluştu..");
            }
           
        }
