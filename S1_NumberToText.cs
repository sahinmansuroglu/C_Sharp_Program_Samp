 //Girilen Bir rakamı yazıya çeviren program
 static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Rakam Giriniz:");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Girilen Sayi={girilenSayi}");
            string metin = String.Empty;
            switch (girilenSayi)
            {
                case 0:
                    metin = "Sıfır";
                    break;
                case 1:
                    metin = "Bir";
                    break;
                case 2:
                    metin = "İki";
                    break;
                case 3:
                    metin = "Üç";
                    break;
                case 4:
                    metin = "Dört";
                    break;
                case 5:
                    metin = "Beş";
                    break;
                case 6:
                    metin = "Altı";
                    break;
                case 7:
                    metin = "Yedi";
                    break;
                case 8:
                    metin = "Sekiz";
                    break;
                case 9:
                    metin = "Dokuz";
                    break;
                default:
                    metin = "Girilen Rakam 0-9 Arası Değildir.";
                    break;


            }

            Console.WriteLine($"{girilenSayi}->{metin}");
        }
